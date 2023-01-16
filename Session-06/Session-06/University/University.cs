using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.University
{

    public class University
    {

        public Student[] Students { get; set; }

        public string[] ProfessorNames { get; set; }

        public University()
        {

            //ProfessorNames = new String[2];

            //ProfessorNames[0] = "Fotis";
            //ProfessorNames[1] = "Dimitris";

            //Students = new Student[2];

            //Student alex = new Student();
            //Student anestis = new Student();

            //Students[0] = alex;
            //Students[1] = anestis;


        }
    }

    //public class Entity {


    //    public Entity() {
    //        ID = Guid.NewGuid(); 
    //    }

    //    public Entity(string name) {
    //        Name = name;
    //    }

    //}

    //public class Animal : Entity {

    //    public Animal(string name) : base(name) {

    //    }
    //}

    public class Person
    {

        // properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        // constructors
        public Person()
        {

        }

        public Person(Guid id)
        {
            ID = id;
        }

        public Person(Guid id, string name)
        {
            ID = id;
            Name = name;
        }

        public Person(Guid id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        // methods
        public void GetName()
        {

        }

        public void SetName(string name)
        {


        }

    }

    public class Student : Person
    {

        public int Grade { get; set; }


        // constructor


        //public Student(string name) : base(name) {

        //}

        //public Student(string name, int age) : base(name, age) {
        //}

        //public Student(string name, int age, int grade) : base(name, age) {
        //    Grade = grade;
        //}

    }
}
