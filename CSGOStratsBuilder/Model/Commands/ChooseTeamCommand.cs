using CSGOStratsBuilder.Model.Domain;
using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.ViewModels;
using System.Collections;
using System.Linq;

namespace CSGOStratsBuilder.Model.Commands {
    public class ChooseTeamCommand : CommandBase {
        private readonly INavigationService _navigationService;

        public ChooseTeamCommand(INavigationService navigationService) {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter) {
            IList items = (IList)parameter;
            if(items.Count != 0) {
                Constants.TeamName = items.Cast<TeamViewModel>().First().Name;
                _navigationService.Navigate();
            }
        }
    }
}
