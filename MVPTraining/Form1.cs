using System;
using System.Windows.Forms;

namespace MVPTraining
{
    public partial class StartingForm : Form, IStartForm
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        public ZoltanControl InstanceOfUserControlOne { get { return zoltanControl1; } }

        public ZoltanControl InstanceOfUserControlTwo { get { return zoltanControl2; } }
    }
}
