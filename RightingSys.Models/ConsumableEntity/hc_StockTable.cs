#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：96ea86c6-7941-4b57-85d2-4e256b907a4e
// 文件名：hc_StockTable
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 13:28:00
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 13:28:00
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;

namespace RightingSys.Models.ConsumableEntity
{
    /// <summary>
    /// 库存表
    /// </summary>
    public  class hc_StockTable:BaseEntity
    {
        /// <summary>
        /// 货品Id
        /// </summary>
        public Guid GoodsId { get; set; }

        /// <summary>
        /// 货品库存
        /// </summary>
        public int GoodsNum { get; set; } = 0;

        /// <summary>
        /// 货品可用库存
        /// </summary>
        public int GoodsTempNum { get; set; } = 0;

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime EditTime { get; set; } = DateTime.Now;
    }
}
