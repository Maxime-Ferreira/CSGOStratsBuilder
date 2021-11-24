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

        public IEnumerable<TeamViewModel> Team => _team;
        public ICommand AddTeamCommand { get; }
        public ICommand ChooseTeamCommand { get; }
        public ICommand DeleteTeamCommand { get; }

        private readonly CreateTeamFile createTeamFile = new CreateTeamFile();
        private readonly ReadTeamFile readTeamFile = new ReadTeamFile();
        private readonly DeleteTeam deleteTeam = new DeleteTeam();

        public ChooseTeamViewModel(TeamStore teamStore, INavigationService addTeamNavigationService, INavigationService configNavigationService) {
            List<string> teamsAlreadyAdded = readTeamFile.Execute();

            _teamStore = teamStore;
            AddTeamCommand = new NavigateCommand(addTeamNavigationService);
            ChooseTeamCommand = new ChooseTeamCommand(configNavigationService);
            DeleteTeamCommand = new DeleteTeamCommand(teamStore);
            _team = new ObservableCollection<TeamViewModel>();
            foreach(string team in teamsAlreadyAdded) {
                _team.Add(new TeamViewModel(team));
            }
            _teamStore.TeamAdded += OnTeamAdded;
            _teamStore.TeamDeleted += OnTeamDeleted;
        }

        private void OnTeamAdded(string name) {
            _team.Add(new TeamViewModel(name));
            createTeamFile.Execute(name);
        }

        private void OnTeamDeleted(string name) {
            TeamViewModel teamViewModelToDelete = null;
            foreach(TeamViewModel teamViewModel in _team) {
                if(teamViewModel.Name == name && teamViewModel != null) {
                    teamViewModelToDelete = teamViewModel;
                }
            }
            _team.Remove(teamViewModelToDelete);
            deleteTeam.Execute("..\\..\\Teams\\teams.xml", name);
        }
    }
}