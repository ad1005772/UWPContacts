using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPContacts
{
    public class ContactsViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
    }
}
