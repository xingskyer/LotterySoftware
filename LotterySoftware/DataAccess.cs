using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace LotterySoftware
{
    public class DataAccess
    {
        public static string CONNECT_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\GiftData.mdb";

        /// <summary>
        /// 查询所有的
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string strSQL)
        {
            try
            {
                OleDbConnection dbconn = new OleDbConnection(CONNECT_STRING);
                dbconn.Open();//建立连接
                OleDbDataAdapter inst = new OleDbDataAdapter(strSQL, dbconn);//选择全部内容                
                DataTable dt = new DataTable();
                inst.Fill(dt);//用inst填充ds                
                dbconn.Close();//关闭连接
                return dt;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 更新、新增
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static int ExcuteNonQuery(string strSQL)
        {
            try
            {
                OleDbConnection dbconn = new OleDbConnection(CONNECT_STRING);

                dbconn.Open();//建立连接
                OleDbCommand myCommand = new OleDbCommand(strSQL, dbconn);//执行命令
                int rst = myCommand.ExecuteNonQuery();//更新数据库，返回受影响行数;可通过判断其是否>0来判断操作是否成功
                dbconn.Close();//关闭连接
                return rst;
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// 查询是否存在
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static string ExecuteScalar(string strSQL)
        {
            try
            {
                OleDbConnection dbconn = new OleDbConnection(CONNECT_STRING);
                dbconn.Open();//建立连接
                OleDbCommand myCommand = new OleDbCommand(strSQL, dbconn);//执行命令
                object rst = myCommand.ExecuteScalar();//更新数据库，返回受影响行数;可通过判断其是否>0来判断操作是否成功
                dbconn.Close();//关闭连接
                if (rst != null)
                {
                    return rst.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
                //}
            }
        }
    }
}
