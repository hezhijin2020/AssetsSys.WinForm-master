#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：73c9875c-1b54-4a3c-a3d0-601800458a62
// 文件名：vmGoods
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-09-19 16:58:33
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-09-19 16:58:33
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightingSys.Models.ConsumableEntity
{
    public class vmGoodsGridView:BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string GoodsCategoryName { get; set; }

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
        public string GoodsSupplierName { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string GoodsUnit { get; set; }

        /// <summary>
        /// 物料条码
        /// </summary>
        public string GoodsSN { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal? GoodsPrice { get; set; } = 0;

        /// <summary>
        /// 数量
        /// </summary>
        public int Num { get; set; }

    }
}
