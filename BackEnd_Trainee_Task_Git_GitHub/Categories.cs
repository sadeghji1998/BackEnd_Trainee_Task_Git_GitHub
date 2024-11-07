using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Trainee_Task_Git_GitHub
{
     class Categories
    {

        public static int Category1 { get; set; } = 1;
        public static int Category2 { get; set; } = 2;
        public static int Category3 { get; set; } = 3;

        public Categories() {}

        public override string ToString()
        {
            return String.Format("Category1: {0}\nCategory2: {1}\nCategory3: {2}",Category1,Category2,Category3);
        }
    }
}
