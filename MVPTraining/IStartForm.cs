using System.Windows.Forms;

namespace MVPTraining
{
    public interface IStartForm
    {
        UserControl InstanceOfUserControlOne { get; }
        UserControl InstanceOfUserControlTwo { get; }
    }
}
