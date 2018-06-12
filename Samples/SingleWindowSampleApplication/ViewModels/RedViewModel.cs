﻿using SimpleWPF.Core.Input;
using SimpleWPF.Core.ViewModels;
using System.Windows.Input;

namespace SingleWindowSampleApplication.ViewModels
{
    public class RedViewModel : SimpleViewModel
    {
        public ICommand GotoBackCommand { get; set; }
        public ICommand GotoBlueCommand { get; set; }
        public ICommand GotoYellowCommand { get; set; }

        public RedViewModel()
        {
            GotoBackCommand = new SimpleRelayCommand(GotoBack);
            GotoBlueCommand = new SimpleRelayCommand(GotoBlue);
            GotoYellowCommand = new SimpleRelayCommand(GotoYellow);
        }

        private void GotoBack()
        {
            NavigateBack();
        }

        private void GotoBlue()
        {
            Navigate(new BlueViewModel());
        }

        private void GotoYellow()
        {
            Navigate(new YellowViewModel());
        }
    }
}