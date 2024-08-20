using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem
{
    internal class Class1
    {
        static string uname;
        static int id;
        static int  userId;
        public static string name
        {
            get
            {
                return uname;
            }
            set
            { uname = value; }
        }
        public static int Id
        {
            get
            {
                return id;
            }
            set
            { id = value; }
        }
        public static int userI
        {
            get
            {
                return userId;
            }
            set
            { userId = value; }
        }
    }
}
