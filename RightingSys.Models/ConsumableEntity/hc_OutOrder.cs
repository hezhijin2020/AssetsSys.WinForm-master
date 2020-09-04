#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：d1f3cf1b-fdf1-4fdf-ae30-00f1eae3af56
// 文件名：hc_OutOrder
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 11:10:38
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 11:10:38
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace RightingSys.Models.ConsumableEntity
{
    public class hc_OutOrder
    {
        /// <summary>
        /// 出库单号
        /// </summary>
        public string OrderSN { get; set; }
        /// <summary>
        ///出库日期
        /// </summary>
        public string OrderDate { get; set; }
        /// <summary>
        /// 出库申请员ID
        /// </summary>
        public Guid StaffId { get; set; }
        /// <summary>
        /// 出库人员
        /// </summary>
        public string StaffName { get; set; }

        /// <summary>
        /// 部门Id
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 出库操作员ID
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 出库操作员
        /// </summary>
        public string OperatorName { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderState State { get; set; }
        /// <summary>
        /// 出库仓库ID
        /// </summary>
        public Guid DepotId { get; set; }
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
}
