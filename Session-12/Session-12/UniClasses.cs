using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_12 {


    public class Person {

        public Person() {
            ID = Guid.NewGuid();
        }

        public enum GenderEnum { Male, Female, Other }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }
    }

    public class Student : Person {

        public bool Undergraduate { get; set; }

        public Guid UniversityID { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>(); 

    }


    public class University {

        public University(Guid id) {
            ID = id;
        }

        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Region { get; set; }
    }


    public class Course {

        public enum SemesterEnum { Winter, Spring }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public SemesterEnum Semester { get; set; }

    }

    public class Professor : Person {
        
    
    
    }
}
