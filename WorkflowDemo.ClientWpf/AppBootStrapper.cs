using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Ninject;
using WorkflowDemo.ClientWpf.ViewModels;
using WorkflowDemo.ClientWpf.States;

namespace WorkflowDemo.ClientWpf
{
    public class AppBootstrapper : BootstrapperBase
    {
        #region fields and properties
        private IKernel __Kernel = null;
        private IKernel _Kernel
        {
            get
            {
                if (__Kernel == null)
                {
                    __Kernel = new StandardKernel();
                }

                return __Kernel;
            }
        }

        #endregion

        #region constructor
        public AppBootstrapper()
        {
            Initialize();
        }

        #endregion

        #region overrides
        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            base.OnStartup(sender, e);
            DisplayRootViewFor<MainViewModel>();
        }

        protected override void Configure()
        {
            _Kernel.Bind<IWindowManager>().To<WindowManager>().InSingletonScope();
            _Kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
            _Kernel.Bind<TransitionMap>().ToSelf().InSingletonScope();
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            _Kernel.Dispose();
            base.OnExit(sender, e);
        }

        protected override object GetInstance(Type service, string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return _Kernel.Get(service);
            }
            else
            {
                return _Kernel.Get(service, key);
            }
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _Kernel.GetAll(service);
        }

        protected override void BuildUp(object instance)
        {
            _Kernel.Inject(instance);
        }

        #endregion
    }
}
