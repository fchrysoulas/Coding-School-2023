using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11.Libs {

    public enum TeamEnum {
        Red,
        Green,
        Blue,
        Purple,
        Yellow,
        Black
    }

    public class Student {

        public string Name { get; set; }

        public Student(string name ) {
            Name = name;    
        }
    }

    public class Classroom {

        public List<Student> Students { get; set; }

        public Classroom() {
            Students = new List<Student>();
        }

    }


}
