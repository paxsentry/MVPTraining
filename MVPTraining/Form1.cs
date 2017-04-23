using System.Windows.Forms;

namespace MVPTraining
{
    public partial class StartingForm : Form, IStartForm
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        public UserControl InstanceOfUserControlOne { get { return this.zoltanControl1; } }

        public UserControl InstanceOfUserControlTwo { get { return this.zoltanControl2; } }
    }
}
