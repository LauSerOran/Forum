﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forum_client_lourd
{
    public partial class Visiteur : Form
    {
        public Visiteur()
        {
            InitializeComponent();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
