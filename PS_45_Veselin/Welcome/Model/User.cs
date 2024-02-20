using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    internal class User
    {
        public string Names;
        public string Password;
        public UserRolesEnum Role;

        public User(String Names, String Password, UserRolesEnum Role) {
            this.Names = Names;
            this.Password = Password;
            this.Role = Role;
        }   

    }
}
