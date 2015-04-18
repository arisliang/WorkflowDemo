using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowDemo.ClientWpf.States;

namespace WorkflowDemo.ClientWpf.ViewModels
{
    public class Question2ViewModel : BaseViewModel
    {
        #region constructor
        public Question2ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 2 - Question";
        }

        #endregion
    }
}
