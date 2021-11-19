namespace CSGOStratsBuilder.ViewModels {
    public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : BaseViewModel;

    public delegate TViewModel CreateViewModel<TParameter, TViewModel>(TParameter parameter) where TViewModel : BaseViewModel;
}
