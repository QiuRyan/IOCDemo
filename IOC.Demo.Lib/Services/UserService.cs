using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Demo.Lib
{
    public class UserService : IUser
    {
        public string GetUserName()
        {
            return "CurrentUser";
        }
    }

    public class SchoolService : ISchool
    {
        public IUser User;

        public SchoolService(IUser user)
        {
            this.User = user;
        }

        public string GetUser()
        {
            return "School : " + this.User.GetUserName();
        }
    }
}
