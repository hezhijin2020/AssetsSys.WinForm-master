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

using HZJ.ORM.Mapping;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace RightingSys.DAL.Sql
{
    public class SqlHelper
    {
        #region 连接字符串
        /// <summary>
        /// 连接数据库的字符串
        /// </summary>
        private static string conStr = "Data Source=.;Initial Catalog=AssetsSys;User Id=itprogram;Password=!tpr0gram;Connect Timeout=5;";

        #endregion

        /// <summary>
        /// 新增
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="model">参数model</param>
        /// <returns></returns>
        public static bool Insert<T>(T model) where T : Models.BaseEntity, new()
        {
            Type type = typeof(T);
            string SQLString = SqlBuilder<T>.GetInsertSQL();
            var ParaList = type.GetProperties().Select(a => new SqlParameter($"@{a.Name}", a.GetValue(model) ?? DBNull.Value)).ToArray();

            return ExecuteSql(SQLString, ParaList, cmd => cmd.ExecuteNonQuery()> 0);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="model">参数model</param>
        /// <returns></returns>
        public static bool Modify<T>(T model) where T : Models.BaseEntity, new()
        {
            Type type = typeof(T);
            string SQLString = SqlBuilder<T>.GetUpdateSQL();
            var ParaList = type.GetProperties().Select(a => new SqlParameter($"@{a.Name}", a.GetValue(model) ?? DBNull.Value)).ToArray();
            return ExecuteSql(SQLString, ParaList, cmd => cmd.ExecuteNonQuery() > 0);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="Id">ID</typeparam>
        /// <returns></returns>
        public static bool Delete<T>(Guid Id) where T : Models.BaseEntity, new()
        {
            Type type = typeof(T);
            string SQLString = SqlBuilder<T>.GetDeleteSQL();
            return ExecuteSql(SQLString, new SqlParameter[] { new SqlParameter("@Id", Id) }, cmd => cmd.ExecuteNonQuery() > 0);
        }


        /// <summary>
        /// 获取指定ID的实列记录
        /// </summary>
        /// <typeparam name="Id">Id记录</typeparam>
        /// <returns></returns>
        public static T GetOneByModel<T>(Guid Id) where T : Models.BaseEntity, new()
        {
            List<T> ls = new List<T>();
            try
            {
                Type type = typeof(T);
                string SQLString = SqlBuilder<T>.GetOneByIdSQL();
                SqlDataReader reader = ExecuteSql(SQLString, new SqlParameter[] { new SqlParameter("@Id",Id)}, cmd => cmd.ExecuteReader(), false);
                while (reader.Read())
                {
                    T t = System.Activator.CreateInstance(type) as T;
                    foreach (PropertyInfo prop in type.GetProperties())
                    {
                        prop.SetValue(t, reader[prop.GetMapingName()].Equals(DBNull.Value) ? null : reader[prop.GetMapingName()]);
                    }
                    ls.Add(t);
                }
                reader.Close();
                return ls[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetList<T>() where T : Models.BaseEntity, new()
        {
            List<T> ls = new List<T>();
            try {
                Type type = typeof(T);
                string SQLString = SqlBuilder<T>.GetQuerySQL();
                SqlDataReader reader = ExecuteSql(SQLString, null, cmd => cmd.ExecuteReader(), false);
                while (reader.Read())
                {
                    T t = System.Activator.CreateInstance(type) as T;
                    foreach (PropertyInfo prop in type.GetProperties())
                    {
                        prop.SetValue(t, reader[prop.GetMapingName()].Equals(DBNull.Value)?null: reader[prop.GetMapingName()]);
                    }
                    ls.Add(t);
                }
                reader.Close();
                return ls;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 执行SQL方法
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="Pars">参数列表</param>
        /// <param name="func">执行Func委托</param>
        /// <returns></returns>
        public static TResult ExecuteSql<TResult>(string SQLString, SqlParameter[] Pars, Func<SqlCommand, TResult> func,bool IsDispose=true)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand com = new SqlCommand(SQLString, con);
            if (Pars != null)
            {
                com.Parameters.AddRange(Pars);
            }
            try
            {
                con.Open();
                return func.Invoke(com);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (IsDispose)
                {
                    com.Dispose();
                    con.Dispose();
                }
            }
        }
    }
}
