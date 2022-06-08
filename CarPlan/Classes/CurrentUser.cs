using vcids.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcids.Classes
{
    class CurrentUser
    {
        public static int currentCost { get; set; }
        public static int Id { get; set; }
        public static int IdCar { get; set; }
        public static string FullName { get; set; }
        public static string PermissionName { get; set; }
        public static bool AccessClients { get; set; }
        public static bool AccessServices { get; set; }
        public static bool AccessClientsServicrs { get; set; }
        public static bool AccessReport { get; set; }
        public static string platform { get; set; }
    }
}
