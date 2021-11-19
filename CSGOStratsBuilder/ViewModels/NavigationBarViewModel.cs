using CSGOStratsBuilder.Model.Commands;
using CSGOStratsBuilder.Model.Services;
using System.Windows.Input;

namespace CSGOStratsBuilder.ViewModels {
    public class NavigationBarViewModel : BaseViewModel {
        public ICommand NavigateAddTeamCommand { get; }
        public ICommand NavigateConfigCommand { get; }
        public ICommand NavigateStratCommand { get; }

        public NavigationBarViewModel(INavigationService addTeamNavigationService,
            INavigationService configNavigationService,
            INavigationService stratNavigationService) {
            NavigateAddTeamCommand = new NavigateCommand(addTeamNavigationService);
            NavigateConfigCommand = new NavigateCommand(configNavigationService);
            NavigateStratCommand = new NavigateCommand(stratNavigationService);
        }
    }
}
