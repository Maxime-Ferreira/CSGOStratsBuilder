using CSGOStratsBuilder.Model.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CSGOStratsBuilder.ViewModels {
    public class ConfigViewModel : BaseViewModel {
        private string _name;
        public string TeamName {
            get {
                return _name;
            }
            set {
                _name = value;
                OnPropertyChanged(nameof(TeamName));
            }
        }

        public ICommand ChooseCaptainCommand { get; }

        private readonly ObservableCollection<string> _roleT;
        private readonly ObservableCollection<string> _roleCT;

        public IEnumerable<string> RoleT => _roleT;
        public IEnumerable<string> RoleCT => _roleCT;

        public ConfigViewModel() {
            TeamName = ConfigTeamCommand.TeamName;
            _roleT = new ObservableCollection<string>() { "Entry", "Entry2", "Awper", "Lurker", "Support" };
            _roleCT = new ObservableCollection<string>() { "Fixe", "Pivot", "Awper" };
        }
    }
}
