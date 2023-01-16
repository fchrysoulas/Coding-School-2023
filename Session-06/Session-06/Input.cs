using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {


    public class Input {


        public int GetNumber() {

            return Convert.ToInt32(GetString());

        }
       
        public string GetString() {

            string s = Console.ReadLine();

            return s;
        }

    }
}
