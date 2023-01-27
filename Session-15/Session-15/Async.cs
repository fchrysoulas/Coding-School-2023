using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15 {


    public class Cook {

        public string Fry() {

            Thread.Sleep(3000);

            return "Fry Ready!";
        }


        public string Boil() {

            Thread.Sleep(5000);

            return "Boil Ready!";
        }

        public string Bake() {

            Thread.Sleep(10000);

            return "Bake Ready!";
        }

    }


    public class CookAsync {


        public async Task<string> Fry() {

            await Task.Delay(3000);

            return "Fry Ready!";
        }


        public async Task<string> Boil() {

            await Task.Delay(5000);

            return "Boil Ready!";
        }

        public async Task<string> Bake() {

            await Task.Delay(10000);

            return "Bake Ready!";
        }




    }
}
