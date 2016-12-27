using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_SqLite_Synchronization.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool Admin { get; set; }

        public int Contract_Id { get; set; }

        [ForeignKey("Contract_Id")]
        public Contract Contract { get; set; }
    }
}
