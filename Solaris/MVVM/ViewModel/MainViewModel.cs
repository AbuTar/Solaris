using Solaris.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solaris.MVVM.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MessagesModel> Messages { get; set; }
        public ObservableCollection<ContactsModel> Contacts { get; set; }
        public MainViewModel() 
        {
            Messages = new ObservableCollection<MessagesModel>();
            Contacts = new ObservableCollection<ContactsModel>();

            Messages.Add(new MessagesModel
            {
                
            });
        }  
    }
}
