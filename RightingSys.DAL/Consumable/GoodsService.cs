#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：4bab91f5-d53a-4fe3-b60a-802b687b3cc7
// 文件名：GoodsService
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 15:41:27
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 15:41:27
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using RightingSys.Models.ConsumableEntity;
using System.Collections.Generic;

namespace RightingSys.DAL.Consumable
{
    public class GoodsService : IDataService<hc_Goods>
    {
        /// <summary>
        /// 新增方法
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(hc_Goods model)
        {
            throw new System.Exception();

        }

        /// <summary>
        /// 修改方法
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Modify(hc_Goods model) 
        {
            throw new System.Exception();
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <param name="Id">实体Id</param>
        /// <returns></returns>
        public bool Delete(hc_Goods model)
        {
            throw new System.Exception();
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public List<hc_Goods> GetAllList() 
        {
            throw new System.Exception();
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="Id">实体ID</param>
        /// <returns></returns>
        public bool Exists(hc_Goods model)
        {
            throw new System.Exception();
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pageSize">每页数量</param>
        /// <param name="pageIndex">第几页</param>
        /// <returns></returns>
        public List<hc_Goods> GetListPage(int pageSize, int pageIndex)
        {
            throw new System.Exception();
        }
    }
}
