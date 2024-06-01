using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.ValueObjects
{
    public class EmailVO
    {
        private string Email;
        public EmailVO(string email)
        {
            Email = email;
            IsValidEmail(Email);
        }

        private void IsValidEmail(string email)
        {        
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if(!Regex.IsMatch(email, pattern)) throw new ArgumentException(message: "Email invalido");
        }
    }
}