using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    
    public class Institute {

        public int? YearsInService { get; set; }

        public Institute(int? yearsInService) {

            YearsInService = yearsInService;
        }

    }


    public class University : Institute {

        public int Classes { get; set; }

        public University(int yearsInService) : base(yearsInService) {
            
        }

        public University(int? yearsInService, int classes) : base(yearsInService) {
            Classes = classes;
        }
    }


    public class Main {

        private void Run() {
            University uni1 = new University(5);
            University uni2 = new University(null, 5);
        }

    }
}
