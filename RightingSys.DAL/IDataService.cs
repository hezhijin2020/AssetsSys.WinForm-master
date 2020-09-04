#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：8da4b067-2dc8-4fa2-ad8a-e32e7d6c0dfc
// 文件名：IDataService
// 文件功能描述：数据服务成通用接口
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 15:17:05
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 15:17:05
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using RightingSys.Models;
using System.Collections.Generic;

namespace RightingSys.DAL
{
    public interface IDataService<T> where T:BaseEntity
    {
        /// <summary>
        /// 新增方法
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        bool AddNew(T model);

        /// <summary>
        /// 修改方法
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Modify(T model);

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <param name="Id">实体Id</param>
        /// <returns></returns>
        bool Delete(T model);

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        List<T> GetAllList();

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="Id">实体ID</param>
        /// <returns></returns>
        bool Exists(T model);

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pageSize">每页数量</param>
        /// <param name="pageIndex">第几页</param>
        /// <returns></returns>
        List<T> GetListPage(int pageSize, int pageIndex);
    }
}
