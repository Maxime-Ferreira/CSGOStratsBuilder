using CSGOStratsBuilder.ViewModels;

namespace CSGOStratsBuilder.Model.Stores
{
    public interface INavigationStore
    {
        BaseViewModel CurrentViewModel { set; }
    }
}