﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private Form _MainMenu;
        public ViewAllQuotes(Form MainMenu)
        {
            InitializeComponent();
            _MainMenu = MainMenu;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MainMenu.Show();
        }
    }
}
