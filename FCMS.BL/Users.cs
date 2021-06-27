using System;
using System.Collections.Generic;
using System.Text;

namespace FCMS.BL
{
    public class Users
    {
        public string username;
        public string password;
        private readonly int id;
        public Users(string username, string password, int id)
        {
            this.username = username;
            this.password = password;
            this.id = id;
        }
    }
}
