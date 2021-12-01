using CSGOStratsBuilder.Model.Commands;

namespace CSGOStratsBuilder.ViewModels {
    public class StratViewModel : BaseViewModel {
        private string _teamName = StratViewCommand.TeamName;
        public string TeamName {
            get {
                return _teamName;
            }
            set {
                _teamName = value;
                OnPropertyChanged(nameof(TeamName));
            }
        }
    }
}
