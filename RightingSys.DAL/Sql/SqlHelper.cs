#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：8cfc2303-cd21-4f15-a81e-082cd8aa3765
// 文件名：SqlHelper
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-09-01 8:14:41
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-09-01 8:14:41
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Data.SqlClient;
using System.Linq;

namespace RightingSys.DAL.Sql
{
    public class SqlHelper
    {
        #region 连接字符串
        /// <summary>
        /// 连接数据库的字符串
        /// </summary>
        private static string conStr = "Data Source=172.20.58.23;Initial Catalog=AssetsSys;User Id=itprogram;Password=!tpr0gram;Connect Timeout=5;";

        #endregion

        /// <summary>
        /// 新增
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="model">参数model</param>
        /// <returns></returns>
        public static bool Insert<T>(T model) where T:Models.BaseEntity,new()
        {
            Type type = typeof(T);
            string SQLString = SqlBuilder<T>.GetInsertSQL();
            var ParaList=  type.GetProperties().Select(a => new SqlParameter($"@{a.Name}", a.GetValue(model)??DBNull.Value)).ToArray();
            return  ExecuteSql(SQLString, ParaList, cmd => cmd.ExecuteNonQuery() > 0);
          
        }


        /// <summary>
        /// 执行SQL方法
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="Pars">参数列表</param>
        /// <param name="func">执行Func委托</param>
        /// <returns></returns>
        public static TResult ExecuteSql<TResult>(string SQLString, SqlParameter[] Pars, Func<SqlCommand, TResult> func)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(SQLString, con))
                {
                    com.Parameters.AddRange(Pars);
                    con.Open();
                    return func.Invoke(com);
                }
            }
        }
    }
}
