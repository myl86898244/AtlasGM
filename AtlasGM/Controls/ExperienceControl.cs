﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasGM.Controls
{
    /// <summary>
    /// 给自己增加经验
    /// </summary>
    public partial class ExperienceControl :UserControl
    {
        public event DelegateSendClick SendClick;
        public ExperienceControl()
        {
            InitializeComponent();
        } 
        private void AddExperience_Click(object sender, EventArgs e)
        {
            ((Button)sender).Tag = new { IsOnly = IsOnly.Checked, Exp = Exp.Text };
            SendClick(sender, e);
        }
    }
}
