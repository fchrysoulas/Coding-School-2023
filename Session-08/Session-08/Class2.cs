using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Session_08 {
    
    internal class Class2 {


        public void Test() {

            int i = 5;

            int j = PSum(i);

            // j == 15 (success)

        }

        private int PSum(int i) {

            // 5 + 4 + 3 + 2 + 1

            int res = 0;

            if (i >= 1) {
                res = i + PSum(i - 1);
            }

            return res;

        }



    }
}
