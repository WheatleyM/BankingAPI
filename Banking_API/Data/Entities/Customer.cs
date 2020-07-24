using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Banking_API.Data.Entities
{
    [Table ("Customers", Schema = "dbo" )]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }        
        public string LName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public int TelNo { get; set; }
        public string PWord { get; set; }


    }
}
