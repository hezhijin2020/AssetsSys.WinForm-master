#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：be3b447b-9db6-405f-b622-c76627ce539a
// 文件名：SqlBuilder
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-09-01 8:15:25
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-09-01 8:15:25
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion


using HZJ.ORM.Mapping;
using HZJ.ORM.SqlFilter;
using RightingSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.DAL.Sql
{
    /// <summary>
    /// SQL语句生成类
    /// </summary>
    /// <typeparam name="T">泛型类型</typeparam>
    public class SqlBuilder<T> where T : BaseEntity
    {
        private static string _InsertSQL =null;
        private static string _QuerySQL = null;
        private static string _UpdateSQL =null;
        private static string _DeleteSQL =null;
        private static string _QueryByPageSQL = null;
        private static string _TableName = null;
        private static string _ColumnsString = null;
        private static List<string> _Columns = null;


        /// <summary>
        /// 构造函数
        /// </summary>
        static SqlBuilder()
        {
            Type type = typeof(T);
            _TableName = type.Name;
            _Columns = type.GetProperties().Select(a => $"[{a.GetMapingName()}]").ToList();
            #region InsertSQL
            {
                _ColumnsString = string.Join(",", _Columns);
                var _ParsString=string.Join(",",type.GetProperties().Select(a=>$"@{a.Name}"));
                _InsertSQL = $"Insert into [{_TableName}] ({_ColumnsString}) values({_ParsString})";
            }
            #endregion

            #region QuerySQL
            {
                _QuerySQL = $"Select {_ColumnsString} From [{_TableName}]";
            }
            #endregion

            #region UpdateSQL
            {
                var UpdateString = string.Join(",", type.GetPropertiesWithoutKey().Select(a => $"[{a.GetMapingName()}]=@{a.Name}"));
                _UpdateSQL = $"Update [{_TableName}] Set {UpdateString} Where [Id]=@Id";
            }
            #endregion

            #region DeleteSQL
            {
                _DeleteSQL = $"Delete [{_TableName}] Where [Id]=@Id";
            }
            #endregion
        }


        /// <summary>
        ///获取插入SQL语句
        /// </summary>
        /// <returns></returns>
        public static string GetInsertSQL()
        {
            return _InsertSQL;
        }

        /// <summary>
        /// 获取查询SQL语句
        /// </summary>
        /// <returns></returns>
        public static string GetQuerySQL()
        {
            return _QuerySQL;
        }

        /// <summary>
        /// 获取指定Id的记录
        /// </summary>
        /// <returns></returns>
        public static string GetOneByIdSQL()
        {
            return _QuerySQL+$" Where [Id]=@Id";
        }

        /// <summary>
        /// 查询分页数据
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页条数</param>
        /// <returns></returns>
        public static string GetListByPage(int pageIndex,int pageSize)
        {
            int Num1 = (pageIndex-1)*pageSize;
            int Num2 = pageIndex * pageSize; ;
            Type type = typeof(T);
            _TableName = type.Name;
            return _QueryByPageSQL = $"select a.* from(select  ROW_NUMBER() over(order by CreateTime,Id asc) RowNum, *from [{_TableName}] ) as a   where RowNum>{Num1} and RowNum=<{Num2}";
        }

        /// <summary>
        /// 获取更新SQL语句
        /// </summary>
        /// <returns></returns>
        public static string GetUpdateSQL()
        {
            return _UpdateSQL;
        }

        /// <summary>
        /// 获取删除SQL语句
        /// </summary>
        /// <returns></returns>
        public static string GetDeleteSQL()
        {
            return _DeleteSQL;
        }
    }
}
