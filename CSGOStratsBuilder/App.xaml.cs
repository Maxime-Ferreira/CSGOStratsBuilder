using CSGOStratsBuilder.Model.Services;
using CSGOStratsBuilder.Model.Stores;
using CSGOStratsBuilder.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace CSGOStratsBuilder {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {

        private readonly IServiceProvider _serviceProvider;

        public App() {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<NavigationStore>();
            services.AddSingleton<TeamStore>();
            services.AddSingleton<ModalNavigationStore>();

            services.AddSingleton<INavigationService>(s => CreateChooseTeamNavigationService(s));
            services.AddSingleton<CloseModalNavigationService>();

            services.AddTransient<AddTeamViewModel>(s => new AddTeamViewModel(s.GetRequiredService<TeamStore>(), s.GetRequiredService<CloseModalNavigationService>()));
            services.AddTransient<ConfigViewModel>(s => new ConfigViewModel());
            services.AddTransient<StratViewModel>(s => new StratViewModel());
            services.AddTransient<ChooseTeamViewModel>(s => new ChooseTeamViewModel(s.GetRequiredService<TeamStore>(), CreateAddTeamNavigationService(s), CreateConfigNavigationService(s)));
            services.AddTransient<NavigationBarViewModel>(CreateNavigationBarViewModel);
            services.AddSingleton<MainViewModel>();

            services.AddSingleton<MainWindow>(s => new MainWindow() {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e) {
            INavigationService initialNavigationService = _serviceProvider.GetRequiredService<INavigationService>();
            initialNavigationService.Navigate();

            MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }

        private INavigationService CreateAddTeamNavigationService(IServiceProvider serviceProvider) {
            return new ModalNavigationService<AddTeamViewModel>(
                 serviceProvider.GetRequiredService<ModalNavigationStore>(),
                 () => serviceProvider.GetRequiredService<AddTeamViewModel>());
        }

        private INavigationService CreateConfigNavigationService(IServiceProvider serviceProvider) {
            return new LayoutNavigationService<ConfigViewModel>(
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<ConfigViewModel>(),
                () => serviceProvider.GetRequiredService<NavigationBarViewModel>());
        }

        private INavigationService CreateStratNavigationService(IServiceProvider serviceProvider) {
            return new LayoutNavigationService<StratViewModel>(
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<StratViewModel>(),
                () => serviceProvider.GetRequiredService<NavigationBarViewModel>());
        }

        private INavigationService CreateChooseTeamNavigationService(IServiceProvider serviceProvider) {
            return new LayoutNavigationService<ChooseTeamViewModel>(
                serviceProvider.GetRequiredService<NavigationStore>(),
                () => serviceProvider.GetRequiredService<ChooseTeamViewModel>(),
                () => serviceProvider.GetRequiredService<NavigationBarViewModel>());
        }

        private NavigationBarViewModel CreateNavigationBarViewModel(IServiceProvider serviceProvider) {
            return new NavigationBarViewModel(CreateChooseTeamNavigationService(serviceProvider),
                CreateStratNavigationService(serviceProvider));
        }
    }
}