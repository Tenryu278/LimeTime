using System.Data;

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

        #endregion
    }
}