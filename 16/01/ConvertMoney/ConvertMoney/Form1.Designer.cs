﻿namespace ConvertMoney
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtALower = new System.Windows.Forms.TextBox();
            this.txtAUpper = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtALower
            // 
            this.txtALower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtALower.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtALower.Location = new System.Drawing.Point(186, 174);
            this.txtALower.MaxLength = 12;
            this.txtALower.Name = "txtALower";
            this.txtALower.Size = new System.Drawing.Size(226, 16);
            this.txtALower.TabIndex = 0;
            this.txtALower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtALower_KeyPress);
            // 
            // txtAUpper
            // 
            this.txtAUpper.BackColor = System.Drawing.SystemColors.Window;
            this.txtAUpper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAUpper.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAUpper.Location = new System.Drawing.Point(75, 229);
            this.txtAUpper.Name = "txtAUpper";
            this.txtAUpper.ReadOnly = true;
            this.txtAUpper.Size = new System.Drawing.Size(337, 16);
            this.txtAUpper.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(340, 264);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "转换";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 298);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtAUpper);
            this.Controls.Add(this.txtALower);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "金额大小写转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtALower;
        private System.Windows.Forms.TextBox txtAUpper;
        private System.Windows.Forms.Button btnConfirm;



    }
}
