﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using QuickPad.Mvvm.ViewModels;

namespace QuickPad.Mvvm.Commands.Actions
{
    public class ShowSettingsCommand : SimpleCommand<SettingsViewModel>
    {
        public ShowSettingsCommand()
        {
            Executioner = settings =>
            {
                //open settings page
                settings.ShowSettings = !settings.ShowSettings;

                return Task.CompletedTask;
            };
        }
    }
}
