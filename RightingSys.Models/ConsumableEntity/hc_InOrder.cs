#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：68f90134-b05f-4909-8b53-66b2a89d5a90
// 文件名：hc_Order
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 10:23:13
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 10:23:13
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace RightingSys.Models.ConsumableEntity
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class hc_InOrder:BaseEntity
    {
        /// <summary>
        /// 入库单号
        /// </summary>
        public string OrderSN { get; set; }
        /// <summary>
        ///入库日期
        /// </summary>
        public string OrderDate { get; set; }
        /// <summary>
        /// 入库申请员ID
        /// </summary>
        public Guid CreatorId { get; set; }
        /// <summary>
        /// 入库人员
        /// </summary>
        public string CreatorName { get; set; }
      
        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderState State { get; set; }
        /// <summary>
        /// 入库仓库ID
        /// </summary>
        public  Guid DepotId { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string DepotName { get; set; }
        /// <summary>
        /// 订单描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderReason { get; set; }
    }

    public enum OrderState
    {
        Waiting,
        Cancel,
        Finished
    }
}
