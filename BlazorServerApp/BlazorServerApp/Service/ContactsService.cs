using BlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerApp.Service
{
    public class ContactsService : IContactsService
    {
        /// <summary>
        /// Variable used to be able to connect to the database
        /// </summary>
        private readonly TestContext _dbContext = null;

        /// <summary>
        /// Constructor for database context
        /// </summary>
        public ContactsService(TestContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <summary>
        /// Fetch the data for the contacts from the DB
        /// </summary>
        public List<Contact> getContacts()
        {
            return _dbContext.Contacts.ToList();
        }

    }
}
