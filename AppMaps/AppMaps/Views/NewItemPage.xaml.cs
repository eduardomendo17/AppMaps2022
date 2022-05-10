using System;
using System.Collections.Generic;
using System.ComponentModel;

using AppMaps.Models;
using AppMaps.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMaps.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}