﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KonevaDD.Sprint7.Project.V10
{
    public partial class FormAboutMe : Form
    {
        public FormAboutMe()
        {
            InitializeComponent();
        }

        private void buttonOK_KDD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}