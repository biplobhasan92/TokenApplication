using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.App_Code
{
    class clsTokenInfo
    {
        public string TokenID { get; internal set; }
        public string EmpID { get; internal set; }
        public object GroupID { get; internal set; }
        public string Comments { get; internal set; }
        public string UserID { get; internal set; }
    }
}
