using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eJobsSmsManager.Controller
{

    static class SmsFactory
    {
        public static ISmsSender getSystem(string Project)
        {
            switch (Project)
            {
                case "eJobs":
                    return new eJobSys();
                    //add new system here
                default:
                    return null;

            }
        }
    }
}
