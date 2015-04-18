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
    public class Question2ViewModel : BaseViewModel
    {
        #region fields and properties
        public bool Question1
        {
            get
            {
                return this.State.Question1;
            }
            set
            {
                this.State.Question1 = value;
                NotifyOfPropertyChange(() => Question1);
                NotifyOfPropertyChange(() => QuestionButtonLabel);
            }
        }

        public string QuestionButtonLabel
        {
            get
            {
                return Question1 ? "Yes" : "No";
            }
        }

        #endregion

        #region constructor
        public Question2ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 2 - Question";
        }

        #endregion

        public override void Next()
        {
            this.NextTransition = Question1 ? StateTransition.OPTION1 : StateTransition.OPTION2;
            this.TryClose();
        }
    }
}
