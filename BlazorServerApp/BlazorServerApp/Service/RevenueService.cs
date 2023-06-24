using BlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerApp.Service
{
    public class RevenueService : IRevenueService
    {

        private readonly TestContext _dbContext = null;

        public RevenueService(TestContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Revenue> getRevenues()
        {
            return _dbContext.Revenues.ToList();
        }
    }
}
