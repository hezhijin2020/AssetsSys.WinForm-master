#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：cdcb5ea1-cc6e-4378-b355-3c66d842aa2a
// 文件名：ys_Category
// 文件功能描述：耗材和资共用类别实体
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 14:18:20
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 14:18:20
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;

namespace RightingSys.Models.CommEntity
{
    /// <summary>
    /// 商品类别
    /// </summary>
    public class ys_Category : BaseEntity
    {
        /// <summary>
        /// 上级类别ID
        /// </summary>
        public Guid ParentId { get; set; } = Guid.Empty;

        /// <summary>
        /// 类别名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        public string SortCode { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        public string SimpleCode { get; set; }

    }
}
