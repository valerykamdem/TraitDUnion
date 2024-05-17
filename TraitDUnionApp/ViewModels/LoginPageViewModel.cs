﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitDUnionApp.ViewModels
{
    public partial class LoginPageViewModel: BaseViewModel
    {
        [ObservableProperty]
        private string? _userName;

        [ObservableProperty]
        private string? _password;
    }
}
