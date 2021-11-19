using CSGOStratsBuilder.ViewModels;
using System.Windows.Input;

namespace CSGOStratsBuilder.Model.Commands {
    public delegate ICommand CreateCommand<TViewModel>(TViewModel viewModel) where TViewModel : BaseViewModel;
}
