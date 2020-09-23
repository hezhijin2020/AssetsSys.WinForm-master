#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：2b8c481b-ee63-4f88-a92f-e28536fc0ae3
// 文件名：hc_Goods
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 9:55:08
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 9:55:08
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;

namespace RightingSys.Models.ConsumableEntity
{
    /// <summary>
    /// 商品实体
    /// </summary>
    public class hc_Goods:BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public Guid? GoodsCategoryId { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string GoodsBrand { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string GoodsModel { get; set; }

        /// <summary>
        /// 供应商Id
        /// </summary>
        public Guid? GoodsSupplierId { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string GoodsUnit { get; set; }
        /// <summary>
        /// 采购员
        /// </summary>
        public Guid? GoodsBuyerId { get; set; }
        /// <summary>
        /// 物料条码
        /// </summary>
        public string GoodsSN { get; set; }
        /// <summary>
        /// 库存上限
        /// </summary>
        public int? GoodsMaxCount { get; set; } = 20;
        /// <summary>
        /// 库存下限
        /// </summary>
        public int? GoodsMinCount { get; set; } = 0;

        /// <summary>
        /// 价格
        /// </summary>
        public decimal? GoodsPrice { get; set; } = 0;

        
    }
}
