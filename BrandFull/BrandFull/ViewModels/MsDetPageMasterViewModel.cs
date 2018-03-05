using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BrandFull.Models;

namespace BrandFull.ViewModels
{
    class MsDetPageMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MsDetPageMenuItem> MenuItems { get; set; }

        public MsDetPageMasterViewModel()
        {
            //MenuItems = new ObservableCollection<MsDetPageMenuItem>(new[]
            //{
            //    new MsDetPageMenuItem { Id = 0, Title = "My ACCOUNT", IconUrl="contacts.png" },
            //    new MsDetPageMenuItem { Id = 1, Title = "SHOP", IconUrl="https://xamarin.com/content/images/pages/forms/example-app.png" },
            //    new MsDetPageMenuItem { Id = 2, Title = "FAQ", IconUrl="todo.png" },
            //    new MsDetPageMenuItem { Id = 3, Title = "NOTIFICATIONS", IconUrl="reminders.png" },
 
            //});
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
