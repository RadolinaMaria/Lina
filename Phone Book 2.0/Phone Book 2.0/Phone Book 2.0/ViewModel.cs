using System;
using System.Collections;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Phone_Book_2
{
    public static class ViewModel
{
    public static ObservableCollection<Contact> Contacts;

    static ViewModel()
    {
        Contacts = new ObservableCollection<Contact>();

        BindingBase.EnableCollectionSynchronization(Contacts, null, Callback);
    }

    private static void Callback(IEnumerable collection, object context, Action accessMethod, bool writeAccess)
    {
        lock (collection)
        {
            accessMethod?.Invoke();
        }
    }
}
}