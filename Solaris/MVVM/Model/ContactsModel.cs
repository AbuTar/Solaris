using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solaris.MVVM.Model
{
    class ContactsModel
    {
        public string Username { get; set; }
        public string ProfilePictureSource { get; set; }

        public ObservableCollection<MessagesModel> Messages { get; set; }

        public string LastMessage => Messages.Last().Message;
        
    }


}
