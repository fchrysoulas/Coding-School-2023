using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10.Libs {


    public class Institute {

        public Guid ID { get; set; }
        public string Name { get; set; }

        public Institute() {
            ID = Guid.NewGuid();    
        }
    }

    public class University : Institute {

       
        public List<Student> Students { get; set; }

        public University() {
            Students = new List<Student>();
        }

    }

    public class Person {

        public Guid ID { get; set; }

        public Person() {
            ID = Guid.NewGuid();
        }
    }

    public class Student : Person {

        public string Name { get; set; }
        public int Age { get; set; }


    }
}
