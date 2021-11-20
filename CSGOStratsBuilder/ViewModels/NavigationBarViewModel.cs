using CSGOStratsBuilder.Model.Commands;
using CSGOStratsBuilder.Model.Services;
using System.Windows.Input;

namespace CSGOStratsBuilder.ViewModels {
    public class NavigationBarViewModel : BaseViewModel {
        public ICommand NavigateConfigCommand { get; }
        public ICommand NavigateStratCommand { get; }

        public NavigationBarViewModel(INavigationService configNavigationService,
            INavigationService stratNavigationService) {
            NavigateConfigCommand = new NavigateCommand(configNavigationService);
            NavigateStratCommand = new NavigateCommand(stratNavigationService);
        }
    }
}
