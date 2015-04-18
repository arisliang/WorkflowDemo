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
    public class ApplicationControllerViewModel : Conductor<IScreen>.Collection.OneActive
    {
        #region dependencies
        private readonly TransitionMap _Map = null;

        #endregion

        #region constructor
        public ApplicationControllerViewModel(TransitionMap map)
        {
            _Map = map;

            this.DisplayName = "Main Window";

            InitializeMap();
            ActivateFirstScreen();
        }

        private void ActivateFirstScreen()
        {
            var screen = IoC.Get<Input1ViewModel>();
            this.ActivateItem(screen);
        }

        private void InitializeMap()
        {
            _Map.AddTransition<Input1ViewModel, Question2ViewModel>(StateTransition.INPUT1SUCCESS);
            _Map.AddTransition<Input1ViewModel, Input1ViewModel>(StateTransition.CANCEL);

            _Map.AddTransition<Question2ViewModel, Input3ViewModel>(StateTransition.OPTION1);
            _Map.AddTransition<Question2ViewModel, Finalize4ViewModel>(StateTransition.OPTION2);
            _Map.AddTransition<Question2ViewModel, Input1ViewModel>(StateTransition.CANCEL);

            _Map.AddTransition<Input3ViewModel, Finalize4ViewModel>(StateTransition.INPUT3SUCCESS);
            _Map.AddTransition<Input3ViewModel, Input1ViewModel>(StateTransition.CANCEL);

            _Map.AddTransition<Finalize4ViewModel, Input1ViewModel>(StateTransition.CANCEL);
        }

        #endregion

        #region overrides
        protected override IScreen DetermineNextItemToActivate(IList<IScreen> list, int lastIndex)
        {
            var screenClosed = list[lastIndex] as BaseViewModel;
            var state = screenClosed.State;

            var nextScreenType = _Map.GetNextScreenType(screenClosed);
            var nextScreen = IoC.GetInstance(nextScreenType, null);

            return nextScreen as IScreen;
        }

        #endregion
    }
}
