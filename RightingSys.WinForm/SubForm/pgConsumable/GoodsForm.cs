using RightingSys.WinForm.Utils.clsEnum;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pgConsumable
{
    public partial class GoodsForm : BaseForm
    {
        BLL.GoodsManager manager = new BLL.GoodsManager();
        public GoodsForm()
        {
            InitializeComponent();
        }

        public override void InitFeatureButton()
        {
            base.SetFeatureButton(
                FeatureButton.Add,
                FeatureButton.Query,
                FeatureButton.Modify,
                FeatureButton.Delete,
                FeatureButton.Export,
                FeatureButton.Import,
                FeatureButton.Preview
                );
        }

        public override void AddNew()
        {
            GoodsEditForm goods = new GoodsEditForm();
            if (goods.ShowDialog() == DialogResult.OK)
            {
                Query();
            }
        }

        public override void Query()
        {
            Func<List<Models.ConsumableEntity.hc_Goods>> act = () =>
            {
               return manager.GetAllList();
            };
            // 异步调用委托事件，在委托事件回调方法中，使用任意控件的异步方法把查询结果绑定到数据表控件中
            act.BeginInvoke((result) =>
            {
                List<Models.ConsumableEntity.hc_Goods> dtResult = act.EndInvoke(result);
                // this是当前WinForm窗口的实例，也可以替换为界面中的任意控件示例，如dgvMain.BeginInvoke
                this.BeginInvoke(new Action<List<Models.ConsumableEntity.hc_Goods>>((List<Models.ConsumableEntity.hc_Goods> dtList) =>
                {
                    this.clsGridControl1.DataSource = dtList;
                }), dtResult);
            }, null);
        }

        public override void Modify()
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                Guid Id = Guid.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                var model=  manager.GetOneModel(Id);
                GoodsEditForm sub = new GoodsEditForm(model);
                if (sub.ShowDialog() == DialogResult.OK)
                {
                    Query();
                }
            }
        }
        public override void Delete()
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                Guid Id = Guid.Parse( gridView1.GetFocusedRowCellValue("Id").ToString());
                if (manager.Delete(Id))
                {
                    Query();
                }
            }
        }
    }
}
