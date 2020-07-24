using Banking_API.Configuration;
using Banking_API.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_API.Data
{
    public class DataContextFactory : IDataContextFactory
    {

        private readonly DataBaseSettings dataBaseSettings;

        public DataContextFactory(DataBaseSettings dataBaseSettings)
        {
            this.dataBaseSettings = dataBaseSettings;
        }

        public IBankingContext CreateBankingContext()
        {
            var contextOptionBuilder = new DbContextOptionsBuilder();
            contextOptionBuilder.UseSqlServer(this.dataBaseSettings.Banking_ConnectionString);
            return new BankingContext(contextOptionBuilder.Options);
        }
                
    }
}
