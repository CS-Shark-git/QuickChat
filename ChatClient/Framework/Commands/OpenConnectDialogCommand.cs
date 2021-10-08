﻿using ChatClient.Framework.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatClient.Framework.Commands
{   
    class OpenConnectDialogCommand : Command
    {
        private ConnectDialog _window;

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            _window = new ConnectDialog() {
                Owner = Application.Current.MainWindow
            };
            _window.Closed += OnWindowClosed;
            _window.ShowDialog();
        }

        private void OnWindowClosed(object sender, EventArgs e)
        {
            ((Window)sender).Closed -= OnWindowClosed;
            _window = null;
        }
    }
}
