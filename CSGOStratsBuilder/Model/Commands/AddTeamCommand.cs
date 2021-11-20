using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using CSGOStratsBuilder.ViewModels;

namespace CSGOStratsBuilder.Model.Commands {
    public class AddTeamCommand : CommandBase {
        private readonly AddTeamViewModel _addTeamViewModel;
        private readonly TeamStore _teamStore;
        private readonly INavigationService _navigationService;

        public AddTeamCommand(AddTeamViewModel addTeamViewModel, TeamStore teamStore, INavigationService navigationService) {
            _addTeamViewModel = addTeamViewModel;
            _teamStore = teamStore;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter) {
            string name = _addTeamViewModel.Name;
            _teamStore.AddTeam(name);
            _navigationService.Navigate();
        }
    }
}
