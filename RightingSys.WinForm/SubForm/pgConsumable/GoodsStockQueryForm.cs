using RightingSys.WinForm.Utils.clsEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pgConsumable
{
    public partial class GoodsStockQueryForm : BaseForm
    {
        BLL.GoodsManager Manager = new BLL.GoodsManager();
        public GoodsStockQueryForm()
        {
            InitializeComponent();
        }

        public override void InitFeatureButton()
        {
            base.SetFeatureButton(FeatureButton.Add,FeatureButton.Query);
        }

        public override void AddNew()
        {
            Action func = () =>
            {
                Models.ConsumableEntity.hc_Goods md = null;
                int a = 0;
                for (int i = 0; i < 1000000; i++)
                {
                    md = new Models.ConsumableEntity.hc_Goods();
                    md.Id = Guid.NewGuid();
                    md.GoodsName = $"name{i}";
                    md.GoodsBrand = $"Brand{i}";
                    md.GoodsBuyerId = Guid.Empty;
                    md.GoodsCategoryId = Guid.Empty;
                    md.GoodsMaxCount = 5;
                    md.GoodsMinCount = 1;
                    md.GoodsSN = $"SN{i}";
                    md.GoodsUnit = "个";
                    md.GoodsPrice = 10;
                    md.GoodsSupplierId = Guid.Empty;
                    md.GoodsModel = $"Model{i}";
                    if (!Manager.AddNew(md))
                    {
                        a++;
                    }
                    else
                    {
                        continue;
                    }
                }
            };

          func.Invoke();

        }

        public override void Query()
        {
            base.Query();
        }

    }
}
