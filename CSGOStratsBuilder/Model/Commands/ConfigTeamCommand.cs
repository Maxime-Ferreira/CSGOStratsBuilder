using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.ViewModels;
using System.Linq;

namespace CSGOStratsBuilder.Model.Commands {
    public class ConfigTeamCommand : CommandBase {
        private readonly INavigationService _navigationService;
        public static string TeamName;

        public ConfigTeamCommand(INavigationService navigationService) {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter) {
            System.Collections.IList items = (System.Collections.IList)parameter;
            TeamName = items.Cast<TeamViewModel>().First().Name;
            _navigationService.Navigate();
        }
    }
}
