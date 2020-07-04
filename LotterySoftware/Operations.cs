using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LotterySoftware
{
    public class Operations
    {
        /// <summary>
        /// 获取全部记录
        /// </summary>
        /// <returns></returns>
        public static DataTable GetPersonnels()
        {
            string strSQL = "SELECT PersonnelID,PersonnelName AS 奖品名称,PersonnelCount AS 奖品数量, PersonnelActive AS 是否加入抽奖, AddDate AS 添加日期, ModifyDate AS 修改日期 FROM tb_PersonnelInfo";
            return DataAccess.GetDataTable(strSQL);
        }
        /// <summary>
        /// 查看唯一编号是否存在
        /// </summary>
        /// <param name="strPersonnelNumber"></param>
        /// <returns></returns>
        public static Boolean GetPersonnelExist(string strPersonnelNumber)
        {
            string SQLSelect = "SELECT PersonnelID FROM tb_PersonnelInfo WHERE PersonnelNumber='" + strPersonnelNumber;
            object  rst = DataAccess.ExecuteScalar(SQLSelect);
            if (rst == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }        
        /// <summary>
        /// 按人员号码得到详细信息
        /// </summary>
        /// <param name="strPersonnelNumber">人员号码</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetPersonelDetails(string strPersonnelNumber)
        {
            string SQLSelect = "SELECT PersonnelID,PersonnelName,PersonnelNumber,PersonnelActive FROM tb_PersonnelInfo WHERE PersonnelNumber='" + strPersonnelNumber + "'";
            DataTable dt = DataAccess.GetDataTable(SQLSelect);
            if (dt.Rows.Count > 0)
            {
                Dictionary<string, string> PersonnelInfo = new Dictionary<string, string>();
                PersonnelInfo["PersonnelID"] = dt.Rows[0]["PersonnelID"].ToString();
                PersonnelInfo["PersonnelName"] = dt.Rows[0]["PersonnelName"].ToString();
                PersonnelInfo["PersonnelNumber"] = dt.Rows[0]["PersonnelNumber"].ToString();
                if (dt.Rows[0]["PersonnelActive"].ToString() != null)
                {
                    if (Convert.ToBoolean(dt.Rows[0]["PersonnelActive"].ToString()) == true)
                    {
                        PersonnelInfo["PersonnelActive"] = "参加抽奖";
                    }
                    else
                    {
                        PersonnelInfo["PersonnelActive"] = "不参加抽奖";
                    }
                }
                return PersonnelInfo;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="strPersonnelID">记录号</param>
        /// <returns></returns>
        public static int DeletePersonnelRecord(string strPersonnelID)
        {
            string strSQL = "DELETE FROM tb_PersonnelInfo WHERE PersonnelID='" + strPersonnelID + "'";
            return DataAccess.ExcuteNonQuery(strSQL);
        }
        public static int UpdatePersonnelInformation(Dictionary<string, string> PersonnelInfo)
        {
            if (PersonnelInfo["PersonnelActive"] == "参加抽奖")
            {

            }

            string OptSQL = "UPDATE tb_PersonnelInfo SET PersonnelName='" + PersonnelInfo["PersonnelActive"] + "',PersonnelCount='" + PersonnelInfo["PersonnelActive"] + "',PersonnelActive='" + PersonnelInfo["PersonnelActive"] + "',ModifyDate='" + DateTime.Now + "' WHERE PersonnelID='" + PersonnelInfo["PersonnelActive"] + "'";
            return DataAccess.ExcuteNonQuery(OptSQL);
        }
        public static int AddPersonnelInformation(Dictionary<string, string> PersonnelInfo)
        {
            if (PersonnelInfo["PersonnelActive"] == "参加抽奖")
            { 
            
            }
                string OptSQL = "INSERT INTO tb_PersonnelInfo(PersonnelID,PersonnelName,PersonnelCount,PersonnelActive,addDate,ModifyDate) values('" + PersonnelInfo["PersonnelActive"] + "','" + PersonnelInfo["PersonnelActive"] + "','" + PersonnelInfo["PersonnelActive"] + "','" + PersonnelInfo["PersonnelActive"] + "','" + DateTime.Now + "','" + DateTime.Now + "')";
            return DataAccess.ExcuteNonQuery(OptSQL);
        }
    }
}
