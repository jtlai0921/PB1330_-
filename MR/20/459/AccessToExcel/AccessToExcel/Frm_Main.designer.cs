﻿namespace AccessToExcel
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的設計器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放托管資源，為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 視窗設計器產生的程式碼

        /// <summary>
        /// 設計器支持所需的方法 - 不要
        /// 使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_Table = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SelectExcel = new System.Windows.Forms.Button();
            this.txt_Excel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SelectTxt = new System.Windows.Forms.Button();
            this.txt_Access = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_Table);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_SelectExcel);
            this.groupBox1.Controls.Add(this.txt_Excel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_SelectTxt);
            this.groupBox1.Controls.Add(this.txt_Access);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定";
            // 
            // cbox_Table
            // 
            this.cbox_Table.FormattingEnabled = true;
            this.cbox_Table.Location = new System.Drawing.Point(128, 50);
            this.cbox_Table.Name = "cbox_Table";
            this.cbox_Table.Size = new System.Drawing.Size(121, 20);
            this.cbox_Table.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "請選擇Access資料表：";
            // 
            // btn_SelectExcel
            // 
            this.btn_SelectExcel.Location = new System.Drawing.Point(305, 76);
            this.btn_SelectExcel.Name = "btn_SelectExcel";
            this.btn_SelectExcel.Size = new System.Drawing.Size(50, 23);
            this.btn_SelectExcel.TabIndex = 5;
            this.btn_SelectExcel.Text = "選擇";
            this.btn_SelectExcel.UseVisualStyleBackColor = true;
            this.btn_SelectExcel.Click += new System.EventHandler(this.btn_SelectExcel_Click);
            // 
            // txt_Excel
            // 
            this.txt_Excel.Location = new System.Drawing.Point(128, 77);
            this.txt_Excel.Name = "txt_Excel";
            this.txt_Excel.ReadOnly = true;
            this.txt_Excel.Size = new System.Drawing.Size(172, 21);
            this.txt_Excel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "請選擇Excel文件：";
            // 
            // btn_SelectTxt
            // 
            this.btn_SelectTxt.Location = new System.Drawing.Point(305, 22);
            this.btn_SelectTxt.Name = "btn_SelectTxt";
            this.btn_SelectTxt.Size = new System.Drawing.Size(50, 23);
            this.btn_SelectTxt.TabIndex = 2;
            this.btn_SelectTxt.Text = "選擇";
            this.btn_SelectTxt.UseVisualStyleBackColor = true;
            this.btn_SelectTxt.Click += new System.EventHandler(this.btn_SelectTxt_Click);
            // 
            // txt_Access
            // 
            this.txt_Access.Location = new System.Drawing.Point(128, 23);
            this.txt_Access.Name = "txt_Access";
            this.txt_Access.ReadOnly = true;
            this.txt_Access.Size = new System.Drawing.Size(172, 21);
            this.txt_Access.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請選擇Access文件：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Browse);
            this.groupBox2.Controls.Add(this.btn_Read);
            this.groupBox2.Location = new System.Drawing.Point(10, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(292, 17);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(63, 23);
            this.btn_Browse.TabIndex = 1;
            this.btn_Browse.Text = "查看";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(223, 18);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(63, 23);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "執行";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 179);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "讀取Access資料到Excel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SelectTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.ComboBox cbox_Table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SelectExcel;
        private System.Windows.Forms.TextBox txt_Excel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Access;
        private System.Windows.Forms.Label label1;
    }
}

