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
        #region fields and properties
        public string Input3Field1
        {
            get
            {
                return this.State.Input3Field1;
            }
            set
            {
                this.State.Input3Field1 = value;
                NotifyOfPropertyChange(() => Input3Field1);
            }
        }

        public int Input3Field2
        {
            get
            {
                return this.State.Input3Field2;
            }
            set
            {
                this.State.Input3Field2 = value;
                NotifyOfPropertyChange(() => Input3Field2);
            }
        }

        #endregion

        #region constructor
        public Input3ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 3 - Input";
        }

        #endregion

        public override void Next()
        {
            this.NextTransition = Models.StateTransition.INPUT3SUCCESS;
            this.TryClose();
        }
    }
}
