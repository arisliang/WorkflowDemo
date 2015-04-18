using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowDemo.ClientWpf.States;

namespace WorkflowDemo.ClientWpf.ViewModels
{
    public class Input1ViewModel : BaseViewModel
    {
        #region constructor
        public Input1ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 1 - Input";
        }

        #endregion
    }
}
