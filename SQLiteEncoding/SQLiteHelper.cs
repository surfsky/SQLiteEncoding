using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteEncoding
{
    /// <summary>
    /// SQLite 辅助方法
    /// </summary>
    public static class SQLiteHelper
    {
        //------------------------------------------------------
        // Sqlite utils
        //------------------------------------------------------
        /// <summary>获取表清单</summary>
        public static List<string> GetTables(SQLiteConnection connection)
        {
            List<string> tables = new List<string>();
            DataTable schemaTable = connection.GetSchema("TABLES");
            foreach (DataRow dr in schemaTable.Rows)
            {
                tables.Add(dr["TABLE_NAME"].ToString());
            }
            return tables;
        }


        /// <summary>获取表结构</summary>
        public static DataTable GetTableSchema(SQLiteConnection connection, string tableName)
        {
            DataTable table = null;
            IDbCommand cmd = new SQLiteCommand();
            cmd.CommandText = string.Format("select * from [{0}]", tableName);
            cmd.Connection = connection;
            using (IDataReader reader = cmd.ExecuteReader(CommandBehavior.KeyInfo | CommandBehavior.SchemaOnly))
            {
                table = reader.GetSchemaTable();
            }
            return table;
        }


        /// <summary>获取表数据</summary>
        public static IDataReader GetTableReader(SQLiteConnection connection, string tableName)
        {
            IDbCommand cmd = new SQLiteCommand();
            cmd.CommandText = string.Format("select * from [{0}]", tableName);
            cmd.Connection = connection;
            return cmd.ExecuteReader();
        }


        /// <summary>获取表数据</summary>
        public static DataTable GetTableData(SQLiteConnection connection, string tableName)
        {
            DataSet ds = new DataSet();
            var sql = string.Format("select * from [{0}]", tableName);
            IDbDataAdapter adp = new SQLiteDataAdapter(sql, connection);
            adp.Fill(ds);
            return ds.Tables[0];
        }

    }
}
