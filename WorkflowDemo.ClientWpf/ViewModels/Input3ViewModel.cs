using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowDemo.ClientWpf.States;

namespace WorkflowDemo.ClientWpf.ViewModels
{
    public class Input3ViewModel : BaseViewModel
    {
        #region constructor
        public Input3ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 3 - Input";
        }

        #endregion
    }
}
