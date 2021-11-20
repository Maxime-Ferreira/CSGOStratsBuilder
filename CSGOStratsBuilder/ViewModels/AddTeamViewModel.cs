using CSGOStratsBuilder.Model.Commands;
using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using System.Windows.Input;

namespace CSGOStratsBuilder.ViewModels {
    public class AddTeamViewModel : BaseViewModel {

        private string _name;
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public AddTeamViewModel(TeamStore teamStore, INavigationService closeNavigationService) {
            SubmitCommand = new AddTeamCommand(this, teamStore, closeNavigationService);
            CancelCommand = new NavigateCommand(closeNavigationService);
        }
    }
}