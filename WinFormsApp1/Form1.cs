﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
                MessageBox.Show("Welcome " + nameTextBox.Text);
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text.Length == 0 || nameTextBox.Text.Length > 6)
            {
                nameErrorProvider.SetError(nameTextBox, "Name must contain from 1 to 6 characters");
                e.Cancel = true;
                return;
            }
            nameErrorProvider.SetError(nameTextBox, string.Empty);
            e.Cancel = false;
        }
    }
}
