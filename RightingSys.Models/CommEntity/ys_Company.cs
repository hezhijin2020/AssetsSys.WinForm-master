#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：53c4bc01-6295-4384-9470-e387a8140dde
// 文件名：ys_Company
// 文件功能描述：耗材和资共用供应商实体
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-08-30 14:21:19
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-08-30 14:21:19
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion


namespace RightingSys.Models.CommEntity
{
    /// <summary>
    /// 供应商公司
    /// </summary>
    public class ys_Company : BaseEntity
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        ///联系人
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        ///电话
        /// </summary>
        public string Tell { get; set; }
        /// <summary>
        ///地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        ///描述信息
        /// </summary>
        public string Description { get; set; }

    }


}
