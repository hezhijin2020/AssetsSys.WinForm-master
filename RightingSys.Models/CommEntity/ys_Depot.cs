#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：85bd9e83-9925-4397-9b8c-895f9c39dcc3
// 文件名：ys_Depot
// 文件功能描述：耗材和资共用仓库实体
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 14:18:36
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 14:18:36
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;

namespace RightingSys.Models.CommEntity
{
    /// <summary>
    /// 仓库实体
    /// </summary>
    public class ys_Depot : BaseEntity
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string DepotName { get; set; }

        /// <summary>
        /// 管理员ID
        /// </summary>
        public Guid KeeperId { get; set; }

        /// <summary>
        /// 管理员名称
        /// </summary>
        public string KeeperName { get; set; }

    }
}
