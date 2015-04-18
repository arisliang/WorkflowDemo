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
        private string _results = null;
        public string Results
        {
            get
            {
                return _results;
            }
            set
            {
                _results = value;
                NotifyOfPropertyChange(() => Results);
            }
        }

        #region constructor
        public Finalize4ViewModel(WorkflowState state)
            : base(state)
        {
            this.DisplayName = "Screen 4 - Finalize";

            FormatResults();
        }

        private void FormatResults()
        {
            var builder = new StringBuilder();
            builder.AppendLine("You've finished your task! Results:");
            builder.AppendLine("Input 1/1: " + this.State.Input1Field1);
            builder.AppendLine("Input 1/2: " + this.State.Input1Field2);
            builder.AppendLine("Input 1/3: " + this.State.Input1Field3);
            builder.AppendLine("Question: " + this.State.Question1);
            if (this.State.Question1)
            {
                builder.AppendLine("Input 3/1: " + this.State.Input3Field1);
                builder.AppendLine("Input 3/2: " + this.State.Input3Field2);
            }

            Results = builder.ToString();
        }

        #endregion
    }
}
