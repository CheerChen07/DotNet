﻿namespace DotNet.WinForm.Common.WinControls
{
    partial class UCRoleSelect
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

        #region 组件设计器生成的主键

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用主键编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.pnlRole = new System.Windows.Forms.Panel();
            this.pnlNull = new System.Windows.Forms.Panel();
            this.btnSetNull = new System.Windows.Forms.Button();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlRole.SuspendLayout();
            this.pnlNull.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Location = new System.Drawing.Point(0, 0);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(127, 20);
            this.txtFullName.TabIndex = 0;
            // 
            // pnlRole
            // 
            this.pnlRole.Controls.Add(this.txtFullName);
            this.pnlRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRole.Location = new System.Drawing.Point(0, 0);
            this.pnlRole.Name = "pnlRole";
            this.pnlRole.Size = new System.Drawing.Size(127, 24);
            this.pnlRole.TabIndex = 1;
            // 
            // pnlNull
            // 
            this.pnlNull.Controls.Add(this.btnSetNull);
            this.pnlNull.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNull.Location = new System.Drawing.Point(204, 0);
            this.pnlNull.Name = "pnlNull";
            this.pnlNull.Size = new System.Drawing.Size(50, 24);
            this.pnlNull.TabIndex = 4;
            // 
            // btnSetNull
            // 
            this.btnSetNull.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetNull.Location = new System.Drawing.Point(2, 0);
            this.btnSetNull.Name = "btnSetNull";
            this.btnSetNull.Size = new System.Drawing.Size(48, 24);
            this.btnSetNull.TabIndex = 0;
            this.btnSetNull.Text = "置空";
            this.btnSetNull.UseVisualStyleBackColor = true;
            this.btnSetNull.Click += new System.EventHandler(this.btnSetNull_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.btnSelect);
            this.pnlSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSelect.Location = new System.Drawing.Point(127, 0);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(77, 24);
            this.pnlSelect.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.Location = new System.Drawing.Point(2, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 24);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // UCRoleSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRole);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.pnlNull);
            this.Name = "UCRoleSelect";
            this.Size = new System.Drawing.Size(254, 24);
            this.pnlRole.ResumeLayout(false);
            this.pnlRole.PerformLayout();
            this.pnlNull.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel pnlRole;
        private System.Windows.Forms.Panel pnlNull;
        private System.Windows.Forms.Button btnSetNull;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Button btnSelect;

    }
}
