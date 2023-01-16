using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    internal class Display {


        public void Do() {

            // EX01 -- string 
            Console.WriteLine("Give a string:");

            Input input = new Input();
            
            String k = input.GetString();


            // EX02 -- number
            Console.WriteLine("Give a number:");

            string j = input.GetString();

            //int num2 = Convert.ToInt32(j);

            int number = input.GetNumber();



            // exec break!
            Console.ReadLine();
        }



    }
}
