using CSGOStratsBuilder.Model.UseCase;
using CSGOStratsBuilder.ViewModels;
using System.Linq;

namespace CSGOStratsBuilder.Model.Commands {
    public class DeleteTeamCommand : CommandBase {
        DeleteTeam deleteTeam = new DeleteTeam();
        public static string TeamName;

        public override void Execute(object parameter) {
            System.Collections.IList items = (System.Collections.IList)parameter;
            TeamName = items.Cast<TeamViewModel>().First().Name;
            deleteTeam.Execute("..\\..\\Teams\\teams.xml", TeamName);
        }
    }
}
