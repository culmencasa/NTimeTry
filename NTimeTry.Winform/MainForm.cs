using NTT.DataAccess.Services;
using NTT.PO.User;
using NTT.DataAccess.Services;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Windows.Utils;

namespace NTT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (lvCategoryList.SelectedItems.Count <= 0)
                return;

            CategoryInfo parent = lvCategoryList.SelectedItems[0].Tag as CategoryInfo;

            if (parent == null)
            {
                return;
            }

            AddItemForm form = new AddItemForm();
            form.CategoryEntity = parent;
            form.ShowDialog();
        }

        private void LoadCategories()
        {
            this.lvCategoryList.Items.Clear();

            this.lvCategoryList.BeginUpdate();

            var list = Factory.Entry<CategoryService>().FindAll();
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.Tag = item;
                this.lvCategoryList.Items.Add(lvi);
            }

            this.lvCategoryList.EndUpdate();
        }

        private void lvCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCategoryList.SelectedItems.Count <= 0)
                return;

            CategoryInfo selectedCategory = lvCategoryList.SelectedItems[0].Tag as CategoryInfo;

            lvItemList.Items.Clear();

            lvItemList.BeginUpdate();
            IList<ItemInfo> itemList  = Factory.Entry<ItemService>().SelectByCategoryId(selectedCategory.Id);
            foreach (var item in itemList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.Rate.ToString());
                lvi.SubItems.Add(Conv.NS(item.StartTime));
                lvi.SubItems.Add(Conv.NS(item.FinishTime));
               


                this.lvItemList.Items.Add(lvi);
            }
            lvItemList.EndUpdate();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategoryList.SelectedItems.Count > 0)
            {
                var item = lvCategoryList.SelectedItems[0];
                lvCategoryList.Items.Remove(item);
            }
        }

        private void tsmRename_Click(object sender, EventArgs e)
        {
            if (lvCategoryList.SelectedItems.Count > 0)
            {
                var item = lvCategoryList.SelectedItems[0];
                item.BeginEdit();
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            //e.Cancel = true;
        }

        private void lvCategoryList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView listview = (ListView)sender;
                ListViewItem mouseDownItem = listview.GetItemAt(e.X, e.Y);


                if (mouseDownItem != null)
                {
                    mouseDownItem.Selected = true;
                    this.contextMenuStrip1.Show(listview, e.X, e.Y);
                }
            }
        }

        private void lvCategoryList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            var newValue = e.Label;
            var categoryEntity = this.lvCategoryList.Items[e.Item].Tag as CategoryInfo;
            if (newValue == categoryEntity.Name || string.IsNullOrEmpty(newValue))
            {
                return;
            }


        }
    }
}
