using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using CSGOStratsBuilder.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

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
