using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {

    public  class Manager {

        public int ID { get; set; }

        public Manager() {

        }

        public Manager(int id) {
            ID = id;
        }
    }


    public class Engineer {

        // pk engineer
        public int ID { get; set; }

        // fk manager
        public int ManagerID { get; set; }

        public Manager Manager;
    }


    public class Test {


        private void New() {

            Manager manager = new Manager();
            manager.ID = 1;


            Engineer engineer1 = new Engineer();
            engineer1.ManagerID = 1;
            engineer1.ID = 1;



            Engineer engineer2 = new Engineer();
            engineer2.Manager = new Manager(2);
            engineer2.ID = 2;
            
            
        
        }

    
    }
}
