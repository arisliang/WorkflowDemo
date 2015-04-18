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
        #region fields and properties
        public string Input1Field1
        {
            get
            {
                return this.State.Input1Field1;
            }
            set
            {
                this.State.Input1Field1 = value;
                NotifyOfPropertyChange(() => Input1Field1);
            }
        }

        public string Input1Field2
        {
            get
            {
                return this.State.Input1Field2;
            }
            set
            {
                this.State.Input1Field2 = value;
                NotifyOfPropertyChange(() => Input1Field2);
            }
        }

        public DateTime Input1Field3
        {
            get
            {
                return this.State.Input1Field3;
            }
            set
            {
                this.State.Input1Field3 = value;
                NotifyOfPropertyChange(() => Input1Field3);
            }
        }

        #endregion

        #region constructor
        public Input1ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 1 - Input";
        }

        #endregion

        #region public methods
        public override void Next()
        {
            this.NextTransition = Models.StateTransition.INPUT1SUCCESS;
            this.TryClose();
        }

        #endregion
    }
}
