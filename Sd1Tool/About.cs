﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sd1Tool
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Createrlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
