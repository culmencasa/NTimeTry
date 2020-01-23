using NTT.PO.User;
using NTT.DataAccess.Services;
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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var entity = new CategoryInfo()
            {
                Name = txtCategoryName.Text,
                ColorHex = txtColorHex.Text,
            };
            var result = Factory.Entry<CategoryService>().Insert(entity);
            if (result != null)
            {
                this.Reset();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Reset()
        {
            this.txtCategoryName.Clear();
            this.txtColorHex.Clear();
        }
    }
}
