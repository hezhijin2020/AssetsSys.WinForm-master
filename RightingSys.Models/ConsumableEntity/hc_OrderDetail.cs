#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：d4b050e4-55a8-4d8e-8726-aebb03ac85e4
// 文件名：hc_OrderDetail
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 10:23:36
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 10:23:36
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RightingSys.Models.ConsumableEntity
{
    /// <summary>
    /// 订单明细
    /// </summary>
    public class hc_OrderDetail:BaseEntity
    {
        /// <summary>
        /// 订单单号
        /// </summary>
        public string OrderSN { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string Num { get; set; }

    }


}
