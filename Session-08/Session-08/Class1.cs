using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_08 {

    public interface IEntity { 
    
    }

    public interface ICreate {

    }

    public interface IShape : IEntity, ICreate {

        public int Dimension { get; set; }

        public void Surface();
    }


    public class Circle : IShape {

        public int Dimension { get; set; }
        public Color Paint { get; set; }

        public void Surface() {
            
        }
    }

    public class Square : IShape {

        public int Dimension { get; set; }
        public Color Paint { get; set; }

        public void Surface() {

        }
    }

    public class Person {

    }

    public class Student : Person {

        public int Z { get; set; }

      

       
    }

    public class Test {


        public void Do() {


            Person s = new Student();

            IShape c = new Circle();
            c.Dimension = 0;
            c.Surface();
        
        }

    }

    //public abstract class Shape {

    //    public int Dimension { get; set; }

    //    public abstract decimal Perimeter();

    //    public void Surface() {
            
    //    }
    //}





   


    //public abstract class Circle : Shape {

    //    public abstract decimal Perimeter();


    //    //public override decimal Surface() {

    //    //    return 0;
    //    //}
    //}


    //public class FotisCircle : Circle {

    //    public override decimal Perimeter() {

    //        return 0;
    //    }

    //    public override decimal Surface() {

    //        return 0;
    //    }
    //}


}
