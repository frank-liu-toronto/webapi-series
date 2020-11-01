using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.TokenAuthentication
{
    public class Token
    {
        public string Value { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
