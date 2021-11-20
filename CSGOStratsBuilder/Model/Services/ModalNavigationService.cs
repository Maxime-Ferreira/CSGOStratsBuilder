﻿using CSGOStratsBuilder.Model.Stores;
using CSGOStratsBuilder.ViewModels;
using System;

namespace CSGOStratsBuilder.Model.Services
{
    public class ModalNavigationService<TViewModel> : INavigationService where TViewModel : BaseViewModel
    {
        private readonly ModalNavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public ModalNavigationService(ModalNavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
