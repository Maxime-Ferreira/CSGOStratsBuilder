using CSGOStratsBuilder.Model.Domain;

namespace CSGOStratsBuilder.ViewModels {
    public class StratViewModel : BaseViewModel {
        private string _teamName = Constants.TeamName;
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
