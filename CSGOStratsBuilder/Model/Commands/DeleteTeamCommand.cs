using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using CSGOStratsBuilder.Model.UseCase;
using CSGOStratsBuilder.ViewModels;
using System.Collections;
using System.Linq;

namespace CSGOStratsBuilder.Model.Commands {
    public class DeleteTeamCommand : CommandBase {
        private readonly TeamStore _teamStore;
        

        public DeleteTeamCommand(TeamStore teamStore) {
            _teamStore = teamStore;
        }

        public override void Execute(object parameter) {
            IList items = (IList)parameter;
            string name = items.Cast<TeamViewModel>().First().Name;
            _teamStore.DeleteTeam(name);
        }
    }
}
