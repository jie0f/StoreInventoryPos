using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventoryPos
{
    internal class Users
    {
        public static string Username { get; set; }
        public static string Role { get;  set; }

        public static void SetSession(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public static void ClearSession()
        {
            Username = null;
            Role = null;
        }

    }


}
