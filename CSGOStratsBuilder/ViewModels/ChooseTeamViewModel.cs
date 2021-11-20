using CSGOStratsBuilder.Model.Commands;
using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using CSGOStratsBuilder.Model.UseCase;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CSGOStratsBuilder.ViewModels {
    public class ChooseTeamViewModel : BaseViewModel {
        private readonly TeamStore _teamStore;

        private readonly ObservableCollection<TeamViewModel> _team;

        private CreateTeamFile createTeamFile = new CreateTeamFile();
        private ReadTeamFile readTeamFile = new ReadTeamFile();

        public IEnumerable<TeamViewModel> Team => _team;
        public ICommand AddTeamCommand { get; }
        public ICommand ConfigCommand { get; }
        public ICommand DeleteTeamCommand { get; }

        public ChooseTeamViewModel(TeamStore teamStore, INavigationService addTeamNavigationService, INavigationService configNavigationService) {
            List<string> teamsAlreadyAdded = readTeamFile.Execute();

            _teamStore = teamStore;
            AddTeamCommand = new NavigateCommand(addTeamNavigationService);
            ConfigCommand = new ConfigTeamCommand(configNavigationService);
            DeleteTeamCommand = new DeleteTeamCommand();
            _team = new ObservableCollection<TeamViewModel>();
            foreach(string team in teamsAlreadyAdded) {
                _team.Add(new TeamViewModel(team));
            }
            _teamStore.TeamAdded += OnTeamAdded;
        }

        private void OnTeamAdded(string name) {
            _team.Add(new TeamViewModel(name));
            createTeamFile.Execute(name);
        }
    }
}
