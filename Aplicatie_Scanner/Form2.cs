﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Scanner
{
    public partial class Form_Dialog : Form
    {
        public Form_Dialog()
        {
            InitializeComponent();
        }

        private void Form_Dialog_Load(object sender, EventArgs e)
        {

        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            this.Text = tbDialog.Text;
            this.Close();
        }
    }
}
