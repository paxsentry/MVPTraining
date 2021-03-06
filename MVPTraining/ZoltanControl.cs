﻿using System;
using System.Windows.Forms;

namespace MVPTraining
{
    public partial class ZoltanControl : UserControl, IZoltanControl
    {
        public ZoltanControl()
        {
            InitializeComponent();
        }

        public string ZCLabelText
        {
            get { return ZCLabel.Text; }
            set { ZCLabel.Text = value; }
        }
        public string ZCTextBoxText
        {
            get { return ZCTextBox.Text; }
            set { ZCTextBox.Text = value; }
        }

        public ZoltanPresenter Presenter { private get; set; }

        private void ZCButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void ZCTextBox_TextChanged(object sender, EventArgs e)
        {
            Presenter.SwapText(ZCTextBoxText);
        }
    }
}
