using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Banking_API.Data.Entities
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int AccId { get; set; }
        public int Value { get; set; }
        public DateTime TranDate { get; set; }

    }
}
