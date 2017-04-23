using System.Windows.Forms;

namespace MVPTraining
{
    public interface IStartForm
    {
        ZoltanControl InstanceOfUserControlOne { get; }
        ZoltanControl InstanceOfUserControlTwo { get; }
    }
}
