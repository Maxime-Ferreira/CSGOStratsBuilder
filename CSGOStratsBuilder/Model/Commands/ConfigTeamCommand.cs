using CSGOStratsBuilder.Model.Domain;
using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using CSGOStratsBuilder.Model.UseCase;
using CSGOStratsBuilder.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;

namespace CSGOStratsBuilder.Model.Commands {
    public class ConfigTeamCommand : CommandBase {
        private readonly ConfigViewModel _viewModel;
        private readonly ConfigStore _configStore;
        private readonly INavigationService _navigationService;

        public ConfigTeamCommand(ConfigViewModel viewModel, ConfigStore configStore, INavigationService navigationService) {
            _viewModel = viewModel;
            _configStore = configStore;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter) {
            string teamName = ChooseTeamCommand.TeamName;
            string url = "..\\..\\Teams\\config_" + teamName;

            CreateConfigurationTeam createConfigurationTeam = new CreateConfigurationTeam();

            if (!File.Exists(url)) {
                createConfigurationTeam.CreateConfigFile(url, teamName);
            }

            List<string> playersName = new List<string>() { _viewModel.FirstPlayer, _viewModel.SecondPlayer, _viewModel.ThirdPlayer, _viewModel.FourthPlayer, _viewModel.FifthPlayer };
            List<string> roleT = new List<string>() { _viewModel.FirstRoleT, _viewModel.SecondRoleT, _viewModel.ThirdRoleT, _viewModel.FourthRoleT, _viewModel.FifthRoleT };
            List<string> roleCT = new List<string>() { _viewModel.FirstRoleCT, _viewModel.SecondRoleCT, _viewModel.ThirdRoleCT, _viewModel.FourthRoleCT, _viewModel.FifthRoleCT };

            Team team = createConfigurationTeam.CreateTeam(url, teamName, roleT, roleCT, playersName);  

            _configStore.CurrentTeam = team;

            _navigationService.Navigate();
        }
    }
}
