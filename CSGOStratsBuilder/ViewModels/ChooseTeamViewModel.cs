using CSGOStratsBuilder.Model.Commands;
using CSGOStratsBuilder.Model.Services;
using System.Windows.Input;

namespace CSGOStratsBuilder.ViewModels {
    public class ChooseTeamViewModel : BaseViewModel {
        public ICommand NavigateAddTeamCommand { get; }

        public ChooseTeamViewModel(INavigationService addTeamNavigationService) {
            NavigateAddTeamCommand = new NavigateCommand(addTeamNavigationService);
        }
    }
}
