﻿using System;
using System.Collections.Generic;
using AccessibilitySample.ViewModels;
using AccessibilitySample.Views;
using Xamarin.Forms;

namespace AccessibilitySample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(NewItem2Page), typeof(NewItem2Page));
        }

    }
}
