﻿using Reloaded.Mod.Loader.IO.Config;
using Reloaded.WPF.MVVM;

namespace Reloaded.Mod.Launcher.Models.ViewModel
{
    public class AddAppViewModel : ObservableObject
    {
        public ApplicationConfig Application { get; set; }

        public MainPageViewModel MainPageViewModel { get; set; }
        public int SelectedIndex { get; set; } = 0;

        public AddAppViewModel(MainPageViewModel viewModel)
        {
            MainPageViewModel = viewModel;
        }

        public void RaiseApplicationChangedEvent()
        {
            this.RaisePropertyChangedEvent(nameof(Application));
        }
    }
}