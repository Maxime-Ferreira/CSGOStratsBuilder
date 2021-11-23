using CSGOStratsBuilder.Model.Commands;
using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CSGOStratsBuilder.ViewModels {
    public class ConfigViewModel : BaseViewModel {
        private string _firstPlayer;
        public string FirstPlayer {
            get {
                return _firstPlayer;
            }
            set {
                _firstPlayer = value;
                OnPropertyChanged(nameof(FirstPlayer));
            }
        }

        private string _secondPlayer;
        public string SecondPlayer {
            get {
                return _secondPlayer;
            }
            set {
                _secondPlayer = value;
                OnPropertyChanged(nameof(SecondPlayer));
            }
        }

        private string _thirdPlayer;
        public string ThirdPlayer {
            get {
                return _thirdPlayer;
            }
            set {
                _thirdPlayer = value;
                OnPropertyChanged(nameof(ThirdPlayer));
            }
        }

        private string _fourthPlayer;
        public string FourthPlayer {
            get {
                return _fourthPlayer;
            }
            set {
                _fourthPlayer = value;
                OnPropertyChanged(nameof(FourthPlayer));
            }
        }

        private string _fifthPlayer;
        public string FifthPlayer {
            get {
                return _fifthPlayer;
            }
            set {
                _fifthPlayer = value;
                OnPropertyChanged(nameof(FifthPlayer));
            }
        }

        private string _firstRoleT;
        public string FirstRoleT {
            get {
                return _firstRoleT;
            }
            set {
                _firstRoleT = value;
                OnPropertyChanged(nameof(FirstRoleT));
            }
        }

        private string _secondRoleT;
        public string SecondRoleT {
            get {
                return _secondRoleT;
            }
            set {
                _secondRoleT = value;
                OnPropertyChanged(nameof(SecondRoleT));
            }
        }

        private string _thirdRoleT;
        public string ThirdRoleT {
            get {
                return _thirdRoleT;
            }
            set {
                _thirdRoleT = value;
                OnPropertyChanged(nameof(ThirdRoleT));
            }
        }

        private string _fourthRoleT;
        public string FourthRoleT {
            get {
                return _fourthRoleT;
            }
            set {
                _fourthRoleT = value;
                OnPropertyChanged(nameof(FourthRoleT));
            }
        }

        private string _fifthRoleT;
        public string FifthRoleT {
            get {
                return _fifthRoleT;
            }
            set {
                _fifthRoleT = value;
                OnPropertyChanged(nameof(FifthRoleT));
            }
        }

        private string _firstRoleCT;
        public string FirstRoleCT {
            get {
                return _firstRoleCT;
            }
            set {
                _firstRoleCT = value;
                OnPropertyChanged(nameof(FirstRoleCT));
            }
        }

        private string _secondRoleCT;
        public string SecondRoleCT {
            get {
                return _secondRoleCT;
            }
            set {
                _secondRoleCT = value;
                OnPropertyChanged(nameof(SecondRoleCT));
            }
        }

        private string _thirdRoleCT;
        public string ThirdRoleCT {
            get {
                return _thirdRoleCT;
            }
            set {
                _thirdRoleCT = value;
                OnPropertyChanged(nameof(ThirdRoleCT));
            }
        }

        private string _fourthRoleCT;
        public string FourthRoleCT {
            get {
                return _fourthRoleCT;
            }
            set {
                _fourthRoleCT = value;
                OnPropertyChanged(nameof(FourthRoleCT));
            }
        }

        private string _fifthRoleCT;
        public string FifthRoleCT {
            get {
                return _fifthRoleCT;
            }
            set {
                _fifthRoleCT = value;
                OnPropertyChanged(nameof(FifthRoleCT));
            }
        }

        public ICommand ValidateConfig { get; }

        private readonly ObservableCollection<string> _roleT;
        private readonly ObservableCollection<string> _roleCT;

        public IEnumerable<string> RoleT => _roleT;
        public IEnumerable<string> RoleCT => _roleCT;

        public ConfigViewModel(INavigationService validateConfig, ConfigStore configStore) {
            _roleT = new ObservableCollection<string>() { "Entry", "Entry2", "Awper", "Lurker", "Support" };
            _roleCT = new ObservableCollection<string>() { "Fixe", "Pivot", "Awper" };
            ValidateConfig = new ConfigTeamCommand(this, configStore, validateConfig);
        }
    }
}
