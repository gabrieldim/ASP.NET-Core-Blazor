using BlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerApp.Service
{
    public interface IContactsService 
    {

        List<Contact> getContacts();
    }
}
