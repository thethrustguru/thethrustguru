﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheThrustGuru
{
    public partial class DialogForm : Form
    {
        public DialogForm(string displayText)
        {
            InitializeComponent();
            this.displayLabel.Text = displayText;
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
