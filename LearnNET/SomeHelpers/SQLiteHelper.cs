﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeHelpers
{
    public sealed class SQLiteHelper
    {
        private const string ConnectionStr = "Data Source=recipes.s3db";
        private static SQLiteHelper _instance;
        private static readonly object Locker = new object();

        private SQLiteHelper()
        {
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static SQLiteHelper GetInstance()
        {
            if (_instance == null)
            {
                lock (Locker)
                {
                    if (_instance == null)
                    {
                        _instance = new SQLiteHelper();
                    }
                }
            }

            return _instance;
        }

        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="cmdText"> 需要执行的命令文本 </param>
        /// <returns> 一个数据表集合 </returns>
        public DataTable GetDataTable(string cmdText)
        {
            var dt = new DataTable();

            try
            {
                using (var conn = new SQLiteConnection(ConnectionStr))
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(conn) { CommandText = cmdText };
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return dt;
        }

        /// <summary>
        /// 执行非查询命令
        /// </summary>
        /// <param name="cmdText"> 需要执行的命令文本 </param>
        /// <returns> 返回更新的行数 </returns>
        public int ExecuteNonQuery(string cmdText)
        {
            using (var conn = new SQLiteConnection(ConnectionStr))
            {
                conn.Open();
                var cmd = new SQLiteCommand(conn) { CommandText = cmdText };
                var rowsUpdated = cmd.ExecuteNonQuery();

                return rowsUpdated;
            }
        }

        /// <summary>
        /// 执行检索单项命令
        /// </summary>
        /// <param name="cmdText"> 需要执行的命令文本 </param>
        /// <returns> 一个字符串 </returns>
        public string ExecuteScalar(string cmdText)
        {
            using (var conn = new SQLiteConnection(ConnectionStr))
            {
                conn.Open();
                var cmd = new SQLiteCommand(conn) { CommandText = cmdText };
                var value = cmd.ExecuteScalar();

                if (value != null)
                {
                    return value.ToString();
                }
            }

            return "";
        }

    }
}
