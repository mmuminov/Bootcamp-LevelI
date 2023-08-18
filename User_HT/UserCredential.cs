using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UserCredentials modelidan foydalaning ( id, password, userId )


namespace User_HT
{
    internal class UserCredential
    {
        public UserCredential(string password, Guid userid)
        {
            Password = password;
            Userid = userid;
        }

        public Guid Id { get; set; }
        public string Password { get ; set; }
        public Guid Userid { get; set; }
    }
}
