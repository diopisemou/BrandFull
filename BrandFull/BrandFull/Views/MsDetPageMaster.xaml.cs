using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BrandFull.Models;
using BrandFull.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrandFull.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MsDetPageMaster : ContentPage
    {
        public ListView ListView;

        public MsDetPageMaster()
        {
            InitializeComponent();

            BindingContext = new MsDetPageMasterViewModel();
            ListView = MenuItemsListView;
        }

       
    }
}