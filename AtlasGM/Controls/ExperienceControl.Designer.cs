﻿namespace AtlasGM.Controls
{
    partial class ExperienceControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.部落分享 = new System.Windows.Forms.CheckBox();
            this.AddExperience = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "经验值：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // 部落分享
            // 
            this.部落分享.AutoSize = true;
            this.部落分享.Location = new System.Drawing.Point(177, 15);
            this.部落分享.Name = "部落分享";
            this.部落分享.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.部落分享.Size = new System.Drawing.Size(72, 16);
            this.部落分享.TabIndex = 2;
            this.部落分享.Text = "部落分享";
            this.部落分享.UseVisualStyleBackColor = true;
            // 
            // AddExperience
            // 
            this.AddExperience.Location = new System.Drawing.Point(100, 51);
            this.AddExperience.Name = "AddExperience";
            this.AddExperience.Size = new System.Drawing.Size(75, 23);
            this.AddExperience.TabIndex = 3;
            this.AddExperience.Text = "确定";
            this.AddExperience.UseVisualStyleBackColor = true;
            this.AddExperience.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExperienceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddExperience);
            this.Controls.Add(this.部落分享);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ExperienceControl";
            this.Size = new System.Drawing.Size(273, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox 部落分享;
        private System.Windows.Forms.Button AddExperience;
    }
}
