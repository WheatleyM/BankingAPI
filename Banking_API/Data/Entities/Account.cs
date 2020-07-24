using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Banking_API.Data.Entities
{
    [Table("Account", Schema = "dbo")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int CusId { get; set; }
        public int Balance { get; set; }
        public DateTime LastAccess { get; set; }
    }
}
