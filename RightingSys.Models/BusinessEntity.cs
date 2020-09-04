#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：fb811277-3815-40e4-867b-40d84aa131d1
// 文件名：BusinessEntity
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 14:11:14
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 14:11:14
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightingSys.Models
{
    public class BusinessEntity:BaseEntity
    {
       
        /// <summary>
        /// 操作员Id
        /// </summary>
        public Guid OperatorId { get; set; } = Guid.Empty;

        /// <summary>
        /// 操作员名称
        /// </summary>
        public string OperatorName { get; set; } = "";
    }
}
