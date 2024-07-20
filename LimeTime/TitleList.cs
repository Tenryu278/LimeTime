using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

//Credits:
//3DS TitleID database by 3dsdb
//https://github.com/hax0kartik/3dsdb
//Thanks for Contributors

namespace LimeTime
{
    public class TitleList
    {
        /// <summary>
        /// タイトルDBを格納します
        /// </summary>
        DataTable database = new DataTable();

        /// <summary>
        /// 指定されたリージョンのタイトルDBリストを取得または設定します 
        /// Read or set title database of specified region.
        /// </summary>
        public string Region 
        {
            get
            {
                return database.TableName;
            }
            set 
            {
                string json; //get from resource

                switch (value)
                {
                    case "EUR":
                        json = Properties.Resources.list_GB;
                        break;

                    case "USA":
                        json = Properties.Resources.list_US;
                        break;

                    case "JPN":
                        json = Properties.Resources.list_JP;
                        break;

                    case "KRA":
                        json = Properties.Resources.list_KR;
                        break;

                    case "TWN":
                        json = Properties.Resources.list_TW;
                        break;

                    default:
                        throw new ArgumentException(@"The region is must be ""EUR"", ""USA"", ""JPN"", ""KRA"", ""TWN"".", value);
                }

                database = new DataTable(value); //Init using region

                DataRow row = database.NewRow(); //Add for titledb

                using (var reader = new JsonTextReader(new StringReader(json)))
                {
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.StartObject && database.Columns.Count > 0)
                        {
                            database.Rows.Add(row);
                            row = database.NewRow();
                        }

                        if (reader.TokenType == JsonToken.PropertyName)
                        {
                            string proname = reader.Value.ToString();
                            string val = reader.ReadAsString();

                            if (!database.Columns.Contains(proname))
                                database.Columns.Add(proname);

                            row[proname] = val;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 指定された <paramref name="titleid"/> と同じ行に格納されている <paramref name="parameter"/> 列の値を読み取ります
        /// </summary>
        /// <param name="titleid">TitleID</param>
        /// <param name="parameter"><list type="bullet"><item>Name</item><item>UID</item><item>TitleID</item><item>Version</item><item>Size</item><item>Product Code</item><item>Publisher</item></list></param>
        /// <returns><paramref name="parameter"/> 列に格納されている値。見つからない場合、空の文字列</returns>
        public string GetFrom(string titleid, string parameter)
        {
            return GetFrom("TitleID", titleid, new string[] { parameter })[0];
        }

        /// <summary>
        /// 指定された <paramref name="sourceKey"/> の値が <paramref name="souceValue"/> である行に格納された <paramref name="parameters"/> 列の値を全て読み取ります。
        /// 主キーに設定可能である必要があります
        /// </summary>
        /// <param name="sourceKey"></param>
        /// <param name="souceValue"></param>
        /// <param name="parameters"></param>
        /// <returns><paramref name="parameters"/> 列に格納されている値の配列。見つからない場合、空の文字列が配列に格納されます。</returns>
        public string[] GetFrom(string sourceKey, string souceValue, string[] parameters)
        {
            if (!database.Columns.Contains(sourceKey))
                return null;

            DataColumn[] column = new DataColumn[] { database.Columns[sourceKey] };

            database.PrimaryKey = column; //FIXME:同じNameの値がある(一意性がないので主キーに登録不可)

            DataRow row = database.Rows.Find(souceValue);
            string[] result = new string[parameters.Length];
            for (int i = 0; i < parameters.Length; i++) 
                result[i] = row?[parameters[i]].ToString();

            return result;
        }

        /// <summary>
        /// <see cref="database"/> の <paramref name="parameter"/> 列に格納されたオブジェクトを全て読み取ります
        /// </summary>
        /// <param name="parameter">読み取る <see cref="DataColumn"/> の列名</param>
        /// <returns>オブジェクト型の配列。列が見つからない場合、null</returns>
        public object[] GetColumn(string parameter) 
        {
            return database.Columns[parameter].ItemArray();
        }

        /// <summary>
        /// 指定された<paramref name="index"/>に格納された<see cref="DataRow"/>を読み取ります
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DataRow GetRow(int index)
        {
            return database.Rows[index];
        }

        /// <summary>
        /// 指定された<paramref name="index"/>に格納された<see cref="DataRow"/>の、
        /// <paramref name="parameters"/>列の値を読み取ります
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object[] GetRowObjects(int index, string[] parameters)
        {
            object[] result = new object[parameters.Length];

            for(int i = 0; i < parameters.Length; i++)
            {
                result[i] = database.Rows[index][parameters[i]];
            }
            return result;
        }
    }
}
