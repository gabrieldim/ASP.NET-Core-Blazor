﻿using BlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerApp.Service
{
    public class RevenueService : IRevenueService
    {

        /// <summary>
        /// Variable used to be able to connect to the database
        /// </summary>
        private readonly TestContext _dbContext = null;


        /// <summary>
        /// Constructor for database context
        /// </summary>
        public RevenueService(TestContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <summary>
        /// Fetch all revenues from the DB
        /// </summary>
        public List<Revenue> getRevenues()
        {
            return _dbContext.Revenues.ToList();
        }
    }
}
