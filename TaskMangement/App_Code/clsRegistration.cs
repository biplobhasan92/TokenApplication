using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsRegistration
    {
        public string UserID { get; internal set; }
        public string UserName { get; internal set; }
        public string UserPassword { get; internal set; }
        public string UserConfirmPassword { get; internal set; }
        public string UserType { get; internal set; }
        public string UserStatus { get; internal set; }
    }
}
