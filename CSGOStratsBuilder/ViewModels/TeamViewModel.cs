namespace CSGOStratsBuilder.ViewModels {
    public class TeamViewModel : BaseViewModel {
        public string Name { get; }

        public TeamViewModel(string name) {
            Name = name;
        }
    }
}
