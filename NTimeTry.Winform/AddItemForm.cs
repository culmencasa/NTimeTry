using NTT.DataAccess.Services;
using NTT.PO.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();

            this.Load += AddItemForm_Load;

            
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            if (this.CategoryEntity != null)
            {
                this.lblCategoryName.Text = this.CategoryEntity.Name;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ItemInfo entity = new ItemInfo()
            {
                Name = txtItemName.Text,
                Rate = this.ndRate.Value,
                Total = this.ndTotal.Value,
                Progress = this.ndProgress.Value,
                Category = this.CategoryEntity,
                CategoryId = this.CategoryEntity.Id,
                Remarks = this.txtRemarks.Text,
                CreateTime = DateTime.Now,
                ReviewTime = DateTime.Now,
                StartTime = this.dateTimePicker1.Value, 
                FinishTime = this.dtpFinish.Value
            };

            var result = Factory.Entry<ItemService>().Insert(entity);
            if (result != null && result.Id > 0)
            {
                MessageBox.Show("保存成功");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public CategoryInfo CategoryEntity { get; set; }
    }
}
