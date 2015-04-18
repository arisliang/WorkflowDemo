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
        public WorkflowState State { get; protected set; }
        public StateTransition NextTransition { get; protected set; }

        #endregion

        #region constructor
        protected BaseViewModel(WorkflowState state)
        {
            this.State = state;
        }

        #endregion

        public virtual void Next()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            this.NextTransition = Models.StateTransition.CANCEL;
            this.State = new WorkflowState();
            this.TryClose();
        }
    }
}
