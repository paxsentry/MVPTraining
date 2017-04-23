using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTraining
{
    public class ZoltanPresenter
    {
        private readonly IZoltanControl _view;

        public ZoltanPresenter(IZoltanControl view)
        {
            _view = view;
            view.Presenter = this;
        }

        public void SwapText(string text)
        {
            _view.ZCLabelText = text;
        }
    }
}
