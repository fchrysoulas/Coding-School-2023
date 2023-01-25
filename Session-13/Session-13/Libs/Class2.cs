using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_13.Libs {

    public class Duck {

        public virtual void Quack() {
            // 1.
            // 2.
            // 3.
            // 4.
        }

        public virtual void Swim() {

        }

        public virtual  void Fly() {

            // Do Fly
        }

        public virtual void Eat() {

        }

        public virtual void Sleep() {

        }

    }

    public class BlackDuck : Duck {

        public override void Fly() {
            
            // No Fly
        }

    }


    public sealed class RubberDuck : Duck {

        public override void Quack() {
            // NO
        }

        public override void Fly() {
            // NO
        }

        public override void Sleep() {
            // NO
        }

        public override void Eat() {
            // NO
        }

    }

    public class RedRubberDuck : Duck {


        public override void Quack() {
            // 1.
            // 2.
            // 3.
            // 4.
        }

    }
}
