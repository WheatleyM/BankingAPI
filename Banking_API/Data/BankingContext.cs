using Banking_API.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_API.Data
{
    public class BankingContext : DbContext, IBankingContext
    {
        public BankingContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }
    }
}
