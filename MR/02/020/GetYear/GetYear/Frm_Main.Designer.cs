﻿namespace GetYear
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
            this.btn_GetMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_GetMessage
            // 
            this.btn_GetMessage.Location = new System.Drawing.Point(244, 38);
            this.btn_GetMessage.Name = "btn_GetMessage";
            this.btn_GetMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_GetMessage.TabIndex = 0;
            this.btn_GetMessage.Text = "計算";
            this.btn_GetMessage.UseVisualStyleBackColor = true;
            this.btn_GetMessage.Click += new System.EventHandler(this.btn_GetMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入年份：";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(119, 39);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(79, 21);
            this.txt_year.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "年";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 95);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GetMessage);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用條件運算符判斷指定年份是不是閏年";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label2;
    }
}

