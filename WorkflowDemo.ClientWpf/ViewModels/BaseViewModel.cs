using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowDemo.ClientWpf.Models;
using WorkflowDemo.ClientWpf.States;

namespace WorkflowDemo.ClientWpf.ViewModels
{
    public abstract class BaseViewModel : Screen
    {
        #region fields and properties
        public WorkflowState State { get; set; }
        public StateTransition NextTransition { get; set; }

        #endregion

        #region constructor
        protected BaseViewModel(WorkflowState state)
        {
            this.State = state;
        }

        #endregion
    }
}
