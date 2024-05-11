using Reservoom.Stores;
using Reservoom.ViewModels;
using System;

namespace Reservoom.Services
{
    public class NavigationService
    {
        private readonly NavigationStore _navigationStore;
        public Func<ViewModelBase> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }
        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
