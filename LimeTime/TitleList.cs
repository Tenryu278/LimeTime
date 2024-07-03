using System.Collections.Generic;
using System.Data;
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
    internal class TitleList
    {
        /// <summary>
        /// <see cref="database"/> に指定されたリージョンのDBを格納します
        /// </summary>
        /// <param name="region"></param>
        public TitleList(string region) 
        {
            database = SetRegion(region);
        }

        /// <summary>
        /// タイトルDBを格納します
        /// </summary>
        static DataTable database = new DataTable();

        /// <summary>
        /// 指定されたリージョンのタイトルDBリストを取得します 
        /// Read title database of specified region.
        /// </summary>
        /// <param name="region"><list type="bullet"><item>"EUR"</item><item>"USA"</item><item>"JPN"</item><item>"KRA"</item><item>"TWN"</item></list></param>
        /// <returns>
        /// A DataTable of tltle database. 
        /// This haves TitleName, TitleID, and more info of games. Use when searching a game. 
        /// </returns>
        private DataTable SetRegion(string region)
        {
            DataTable titledb = new DataTable(); //return

            DataRow row = titledb.NewRow(); //Add for titledb

            string json; //get from resource

            switch (region)
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
                    return titledb;
            }
            using (var reader = new JsonTextReader(new StringReader(json)))
            {
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject && titledb.Columns.Count > 0)
                    {
                        titledb.Rows.Add(row);
                        row = titledb.NewRow();
                    }

                    if (reader.TokenType == JsonToken.PropertyName)
                    {
                        string proname = reader.Value.ToString();
                        string val = reader.ReadAsString();

                        if (!titledb.Columns.Contains(proname)) 
                            titledb.Columns.Add(proname);

                        row[proname] = val;
                    }
                }
            }
            return titledb;
        }



        /// <summary>
        /// 指定された <paramref name="titleid"/> と同じ行に格納されている <paramref name="parameter"/> 列の値を読み取ります
        /// </summary>
        /// <param name="titleid">TitleID</param>
        /// <param name="parameter"><list type="bullet"><item>Name</item><item>UID</item><item>TitleID</item><item>Version</item><item>Size</item><item>Product Code</item><item>Publisher</item></list></param>
        /// <returns><paramref name="parameter"/> 列に格納されている値。見つからない場合、空の文字列</returns>
        public static string GetFrom(string titleid, string parameter)
        {
            return GetFrom("TitleID", titleid, new string[] { parameter })[0];
        }

        /// <summary>
        /// 指定された <paramref name="sourceKey"/> の値が <paramref name="souceValue"/> である行に格納された <paramref name="parameters"/> 列の値を全て読み取ります
        /// </summary>
        /// <param name="sourceKey"></param>
        /// <param name="souceValue"></param>
        /// <param name="parameters"></param>
        /// <returns><paramref name="parameters"/> 列に格納されている値の配列。見つからない場合、空の文字列が配列に格納されます。</returns>
        public static string[] GetFrom(string sourceKey, string souceValue, string[] parameters)
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
        public static object[] GetColumn(string parameter) 
        {
            return database.Columns[parameter].ItemArray();
        }

        //debug
        private static void check() 
        {
            object[] objs = database.Columns["Name"].ItemArray();
            IDictionary<object, int> keyValuePairs = new Dictionary<object, int>();
            foreach (object obj in objs) 
            {
                if (!keyValuePairs.ContainsKey(obj)) 
                {
                    keyValuePairs.Add(obj, 0);
                }
                else 
                {
                    keyValuePairs[obj] += 1;
                }
            }

            foreach(var a in keyValuePairs) 
            {
                if (a.Value > 0)
                    MessageBox.Show($"{a.Key.ToString()}\r{a.Value.ToString()}");
            }
        }
    }
}
