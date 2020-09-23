using RightingSys.WinForm.Utils.cls;
using RightingSys.WinForm.Utils.clsControl;
using System;
using System.Windows.Forms;
namespace RightingSys.WinForm.SubForm.pgConsumable
{
    public partial class GoodsEditForm:EditForm
    {
        Models.ConsumableEntity.hc_Goods _model = null;
        BLL.GoodsManager manager = new BLL.GoodsManager();

        /// <summary>
        /// 构造函数（修改带参数）
        /// </summary>
        /// <param name="model"> 实体货品</param>
        public GoodsEditForm(Models.ConsumableEntity.hc_Goods model) : this()
        {
            this.Text= this.Text.Replace("[新增]", "[修改]");
            _model = model;

            #region 控件赋值
            txtGoodsName.Text = _model.GoodsName;
            txtGoodsBrand.Text = _model.GoodsBrand;
            cbGoodsBuyer.EditValue =  _model.GoodsBuyerId;
            cbGoodsCategory.EditValue  = _model.GoodsCategoryId;
            txtMaxNum.Text = _model.GoodsMaxCount.ToString();
            txtMinNum.Text = _model.GoodsMinCount.ToString();
            txtGoodsSN.Text = _model.GoodsSN;
            cbUnit.Text = _model.GoodsUnit;
            txtGoodsPrice.Text = _model.GoodsPrice.ToString();
            cbSupplier.EditValue = _model.GoodsSupplierId;
            txtGoodsModel.Text = _model.GoodsModel;
            #endregion
        }

        /// <summary>
        /// 构造函数（新增无参数）
        /// </summary>
        public GoodsEditForm()
        {
            InitializeComponent();
            this.Text = $"[新增]---{this.Text}";


            AppPublic.Control.InitalControlHelper.ys_AssetsCategory_TreeListLookUpEdit(this.cbGoodsCategory);
            AppPublic.Control.InitalControlHelper.ACL_User_GridLookUpEdit(this.cbGoodsBuyer);
            AppPublic.Control.InitalControlHelper.ys_Company_GridLookUpEdit(this.cbSupplier);


        }

        /// <summary>
        /// 商品信息保存方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (_model == null)
            {
                _model = new Models.ConsumableEntity.hc_Goods();
                _model.Id = Guid.Empty;
            }
            if (txtGoodsName.Text.Trim() == ""
                || cbGoodsCategory.EditValue == null
                || cbUnit.SelectedIndex <= 0
                || txtGoodsModel.Text.Trim() == ""
                || cbSupplier.EditValue == null
                || txtGoodsPrice.Text.Trim() == ""
                || cbGoodsBuyer.EditValue == null)
            {
                clsPublic.ShowMessage("信息输入不全！", Text);
                return;
            }

            _model.GoodsName = txtGoodsName.Text.Trim();
            _model.GoodsBrand = txtGoodsBrand.Text.Trim();
            _model.GoodsBuyerId =clsPublic.GetObjGUID(cbGoodsBuyer.EditValue);
            _model.GoodsCategoryId = clsPublic.GetObjGUID(cbGoodsCategory.EditValue);
            _model.GoodsMaxCount = int.Parse(txtMaxNum.Text);
            _model.GoodsMinCount = int.Parse(txtMinNum.Text);
            _model.GoodsSN = txtGoodsSN.Text;
            _model.GoodsUnit = cbUnit.SelectedItem.ToString();
            _model.GoodsPrice = decimal.Parse(txtGoodsPrice.Text.Trim());
            _model.GoodsSupplierId = clsPublic.GetObjGUID(cbSupplier.EditValue);
            _model.GoodsModel = txtGoodsModel.Text.Trim();

            if (_model.Id == Guid.Empty)
            {
                _model.Id = Guid.NewGuid();
                if (manager.AddNew(_model))
                {
                    base.DialogResult = DialogResult.OK; return;
                }

            }
            else {
                if (manager.Modify(_model))
                {
                    base.DialogResult = DialogResult.OK;
                    return;
                }
            }

            base.DialogResult = DialogResult.Cancel ;
        }

        /// <summary>
        /// 取消修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
