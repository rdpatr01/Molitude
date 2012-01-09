using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSV1
{
    class Global
    {
        static string price1;
        static double Amount;

        static double Cost;
        
        public static double cost
        {
            // allows you to grab the Cost variable
            get { return Cost; }
            //sets Cost variable
            set { Cost = value; }
        }

        public static string Price1
        {
            // allows you to grab the Cost variable
            get { return price1; }
            //sets Cost variable
            set { price1 = value; }
        }

        public static double amount
        {
            // allows you to grab the Cost variable
            get { return Amount; }
            //sets Cost variable
            set { Amount = value; }
        }

    }
}
