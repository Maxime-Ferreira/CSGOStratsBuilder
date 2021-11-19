using CSGOStratsBuilder.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace CSGOStratsBuilder.Views {
    /// <summary>
    /// Logique d'interaction pour AddTeamView.xaml
    /// </summary>
    public partial class AddTeamView : UserControl {
        private readonly AddTeamViewModel _addTeamViewModel = new AddTeamViewModel();
        public AddTeamView() {
            InitializeComponent();
        }

        private void addTeamValid_Click(object sender, RoutedEventArgs e) {
            _addTeamViewModel.Execute(textTeam.Text);
            textTeam.Text = string.Empty;
        }
    }
}
