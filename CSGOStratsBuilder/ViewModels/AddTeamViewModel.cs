using CSGOStratsBuilder.Model.UseCase;

namespace CSGOStratsBuilder.ViewModels {
    public class AddTeamViewModel : BaseViewModel {
        public void Execute(string text) {
            CreateTeamFile createTeam = new CreateTeamFile();
            createTeam.Execute(text);
        }
    }
}