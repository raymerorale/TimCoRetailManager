using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using TRMDesktopUI.EventModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private SimpleContainer _container;
        private SalesViewModel _salesViewModel;
        private IEventAggregator _eventAggregator;
        
        public ShellViewModel(SimpleContainer container, SalesViewModel salesViewModel, IEventAggregator eventAggregator)
        {
            _container = container;
            _salesViewModel = salesViewModel;
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesViewModel);
        }
    }
}
