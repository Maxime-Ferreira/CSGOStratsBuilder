using CSGOStratsBuilder.Model.Domain;
using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.UseCase;
using CSGOStratsBuilder.ViewModels;
using System.Collections.Generic;
using System.IO;

namespace CSGOStratsBuilder.Model.Commands {
    public class ConfigTeamCommand : CommandBase {
        private readonly ConfigViewModel _viewModel;
        private readonly INavigationService _navigationService;

        public ConfigTeamCommand(ConfigViewModel viewModel, INavigationService navigationService) {
            _viewModel = viewModel;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter) {
            string teamName = Constants.TeamName;
            string url = "..\\..\\Teams\\config_" + teamName;

            CreateConfigurationTeam createConfigurationTeam = new CreateConfigurationTeam();

            if (!File.Exists(url)) {
                createConfigurationTeam.CreateConfigFile(url, teamName);
            }

            List<string> playersName = new List<string>() { _viewModel.FirstPlayer, _viewModel.SecondPlayer, _viewModel.ThirdPlayer, _viewModel.FourthPlayer, _viewModel.FifthPlayer };
            List<string> roleT = new List<string>() { _viewModel.FirstRoleT, _viewModel.SecondRoleT, _viewModel.ThirdRoleT, _viewModel.FourthRoleT, _viewModel.FifthRoleT };
            List<string> roleCT = new List<string>() { _viewModel.FirstRoleCT, _viewModel.SecondRoleCT, _viewModel.ThirdRoleCT, _viewModel.FourthRoleCT, _viewModel.FifthRoleCT };

            createConfigurationTeam.CreateTeam(url, teamName, roleT, roleCT, playersName);  

            _navigationService.Navigate();
        }
    }
}
