namespace NTT
{
    partial class AddItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.ndProgress = new System.Windows.Forms.NumericUpDown();
            this.gpNew = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.ndRate = new System.Windows.Forms.NumericUpDown();
            this.ndTotal = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ndProgress)).BeginInit();
            this.gpNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称：";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(161, 37);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 21);
            this.txtItemName.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(34, 100);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(41, 12);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "进度：";
            // 
            // ndProgress
            // 
            this.ndProgress.Location = new System.Drawing.Point(161, 97);
            this.ndProgress.Name = "ndProgress";
            this.ndProgress.Size = new System.Drawing.Size(100, 21);
            this.ndProgress.TabIndex = 3;
            // 
            // gpNew
            // 
            this.gpNew.Controls.Add(this.dateTimePicker1);
            this.gpNew.Controls.Add(this.txtRemarks);
            this.gpNew.Controls.Add(this.dtpFinish);
            this.gpNew.Controls.Add(this.label1);
            this.gpNew.Controls.Add(this.lblFinishTime);
            this.gpNew.Controls.Add(this.lblStartTime);
            this.gpNew.Controls.Add(this.lblRate);
            this.gpNew.Controls.Add(this.txtItemName);
            this.gpNew.Controls.Add(this.ndRate);
            this.gpNew.Controls.Add(this.ndTotal);
            this.gpNew.Controls.Add(this.ndProgress);
            this.gpNew.Controls.Add(this.lblTotal);
            this.gpNew.Controls.Add(this.lblName);
            this.gpNew.Controls.Add(this.lblProgress);
            this.gpNew.Location = new System.Drawing.Point(145, 66);
            this.gpNew.Name = "gpNew";
            this.gpNew.Size = new System.Drawing.Size(450, 326);
            this.gpNew.TabIndex = 4;
            this.gpNew.TabStop = false;
            this.gpNew.Text = "新项";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(36, 241);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(325, 79);
            this.txtRemarks.TabIndex = 7;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(161, 187);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(200, 21);
            this.dtpFinish.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "备注：";
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.AutoSize = true;
            this.lblFinishTime.Location = new System.Drawing.Point(34, 190);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(65, 12);
            this.lblFinishTime.TabIndex = 5;
            this.lblFinishTime.Text = "完成时间：";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(34, 160);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(65, 12);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "开始时间：";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(34, 130);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(41, 12);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "评价：";
            // 
            // ndRate
            // 
            this.ndRate.Location = new System.Drawing.Point(161, 127);
            this.ndRate.Name = "ndRate";
            this.ndRate.Size = new System.Drawing.Size(100, 21);
            this.ndRate.TabIndex = 3;
            // 
            // ndTotal
            // 
            this.ndTotal.Location = new System.Drawing.Point(161, 67);
            this.ndTotal.Name = "ndTotal";
            this.ndTotal.Size = new System.Drawing.Size(100, 21);
            this.ndTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(34, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 12);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "总计：";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(439, 406);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "保存";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(520, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(145, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(41, 12);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "类别：";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(193, 24);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(0, 12);
            this.lblCategoryName.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gpNew);
            this.Name = "AddItemForm";
            this.Text = "创建新项";
            ((System.ComponentModel.ISupportInitialize)(this.ndProgress)).EndInit();
            this.gpNew.ResumeLayout(false);
            this.gpNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.NumericUpDown ndProgress;
        private System.Windows.Forms.GroupBox gpNew;
        private System.Windows.Forms.NumericUpDown ndTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.NumericUpDown ndRate;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}