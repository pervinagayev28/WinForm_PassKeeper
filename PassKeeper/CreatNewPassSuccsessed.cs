﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class CreatNewPassSuccsessed : Form
    {
        public CreatNewPassSuccsessed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.CreatNewPassSuccsessed.Close();
            
        }

        private void CreatNewPassSuccsessed_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.CreatNewPassSuccsessed.Dispose();

        }

        private void CreatNewPassSuccsessed_Load(object sender, EventArgs e)
        {

        }
    }
}
