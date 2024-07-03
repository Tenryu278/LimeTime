using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LimeTime 
{
    public static class Extensions
    {
        #region DataColumn

        /// <summary>
        /// 指定した列に格納されたオブジェクトを全て読み取ります
        /// </summary>
        /// <param name="column">読み取る <see cref="DataColumn"/></param>
        /// <returns>オブジェクト型の配列。列が属するテーブルがない場合、null</returns>
        public static object[] ItemArray(this System.Data.DataColumn column)
        {
            if (column?.Table == null)
                return null;

            DataTable parent = column.Table;

            object[] result = new object[parent.Rows.Count];

            for (int i = 0; i < result.Length; i++)
            {
                DataRow row = parent.Rows[i];
                result[i] = row?[column.ColumnName];
            }
            return result;
        }

        /// <summary>
        /// 一意ではない <see cref="DataColumn"/> の値に <see cref="DataTable.PrimaryKey"/> の値を追加し、一意の列に設定します
        /// </summary>
        /// <param name="column"></param>
        /// <param name="PriKey"></param>
        public static void ToUnique(this System.Data.DataColumn column, DataColumn[] PriKey) 
        {
            object[] vals = column.ItemArray();
            object[] group = vals.GroupBy(value => value).Where(value => value.Count() > 1).Select(Group => Group.Key).ToArray();

            DataTable parent = column.Table;


        }

        #endregion
    }
}