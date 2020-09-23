#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：50a7b8b8-a971-45b2-b49b-6c5ee97c54cf
// 文件名：GoodsManager
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-09-12 11:07:31
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-09-12 11:07:31
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightingSys.BLL
{
    public class GoodsManager
    {

        public bool AddNew(Models.ConsumableEntity.hc_Goods model)
        {
            return DAL.Sql.SqlHelper.Insert<Models.ConsumableEntity.hc_Goods>(model);
        }

        public bool Modify(Models.ConsumableEntity.hc_Goods model)
        {
            return DAL.Sql.SqlHelper.Modify<Models.ConsumableEntity.hc_Goods>(model);
        }

        public bool Delete(Guid Id)
        {
            return DAL.Sql.SqlHelper.Delete<Models.ConsumableEntity.hc_Goods>(Id);
        }

        public List<Models.ConsumableEntity.hc_Goods> GetAllList()
        {
            return DAL.Sql.SqlHelper.GetList<Models.ConsumableEntity.hc_Goods>();
        }

        public Models.ConsumableEntity.hc_Goods GetOneModel(Guid Id)
        {
            return DAL.Sql.SqlHelper.GetOneByModel<Models.ConsumableEntity.hc_Goods>(Id);
        }
    }
}
