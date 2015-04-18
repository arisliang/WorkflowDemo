using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowDemo.ClientWpf.States;

namespace WorkflowDemo.ClientWpf.ViewModels
{
    public class Finalize4ViewModel : BaseViewModel
    {
        #region constructor
        public Finalize4ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 4 - Finalize";
        }

        #endregion
    }
}
