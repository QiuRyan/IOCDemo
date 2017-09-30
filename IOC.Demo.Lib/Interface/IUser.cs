using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Demo.Lib
{
    public interface IUser
    {
        string GetUserName();
    }

    public interface ISchool
    {
        string GetUser();
    }
}
