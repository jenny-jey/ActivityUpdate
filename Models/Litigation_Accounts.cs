using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ActivityUpdate.Models
{
    public class Litigation_Accounts
    {
        [Key]
        public int LitigationAccountID { get; set; }
        public int LitigationCaseID { get; set; }
        public string AccountNumber { get; set; }
    }
}