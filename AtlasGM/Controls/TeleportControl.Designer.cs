﻿namespace AtlasGM.Controls
{
    partial class TeleportControl
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
            this.TextValue = new System.Windows.Forms.TextBox();
            this.TeleportToPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家ID：";
            // 
            // TextValue
            // 
            this.TextValue.Location = new System.Drawing.Point(73, 27);
            this.TextValue.Name = "TextValue";
            this.TextValue.Size = new System.Drawing.Size(100, 21);
            this.TextValue.TabIndex = 1;
            // 
            // TeleportToPlayer
            // 
            this.TeleportToPlayer.Location = new System.Drawing.Point(179, 25);
            this.TeleportToPlayer.Name = "TeleportToPlayer";
            this.TeleportToPlayer.Size = new System.Drawing.Size(75, 23);
            this.TeleportToPlayer.TabIndex = 2;
            this.TeleportToPlayer.Text = "确定";
            this.TeleportToPlayer.UseVisualStyleBackColor = true;
            this.TeleportToPlayer.Click += new System.EventHandler(this.TeleportBut_Click);
            // 
            // TeleportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeleportToPlayer);
            this.Controls.Add(this.TextValue);
            this.Controls.Add(this.label1);
            this.Name = "TeleportControl";
            this.Size = new System.Drawing.Size(283, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextValue;
        private System.Windows.Forms.Button TeleportToPlayer;
    }
}
