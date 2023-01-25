using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session_13.Libs {

    public interface IFeedBehaviour {

        void Do();
    }

    public interface ISleepBehaviour {

        void Do();
    }

    public interface IAnimal {

        IFeedBehaviour FeedBehaviour { get; set; }
        ISleepBehaviour SleepBehaviour { get; set; }

        void Sleep();
        void Feed();

    }

    public class CarnivoreFeedBehaviour : IFeedBehaviour {

        public void Do() {
            // Carnivore Diet Eating
        }
    }

    public class HerbivoreFeedBehaviour : IFeedBehaviour {

        public void Do() {
            // Vegeterian eating 
        }
    }


    

    public class OmnivoreFeedBehaviour : IFeedBehaviour {

        public void Do() {
            HerbivoreFeedBehaviour herbivoreFeedBehaviour = new HerbivoreFeedBehaviour();
            herbivoreFeedBehaviour.Do();

            CarnivoreFeedBehaviour carnivoreFeedBehaviour = new CarnivoreFeedBehaviour();
            carnivoreFeedBehaviour.Do();

            // and something else...

        }
    }

    public class FullSleepBehaviour : ISleepBehaviour {

        public void Do() {

        }
    }


    public class SemiSleepBehaviour : ISleepBehaviour {

        public void Do() {
            
        }
    }

    public class Sheep : IAnimal {

        public IFeedBehaviour FeedBehaviour { get; set; }
        public ISleepBehaviour SleepBehaviour { get; set; }

        public void Feed(IFeedBehaviour feedBehaviour) {
            feedBehaviour.Do();
        }

        public void Feed() {
            throw new NotImplementedException();
        }

        public void Sleep() {
            throw new NotImplementedException();
        }
    }


    public class Cat : IAnimal {

        public IFeedBehaviour FeedBehaviour { get; set; }
        public ISleepBehaviour SleepBehaviour { get; set; }

        public Cat() {

        }

        public Cat(IFeedBehaviour feedBehaviour, ISleepBehaviour sleepBehaviour) {
            FeedBehaviour = feedBehaviour;
            SleepBehaviour = sleepBehaviour;    
        }

        public void Sleep() {
            SleepBehaviour.Do();
        }

        public void Feed() {
            FeedBehaviour.Do();
        }

    }

    public class Dolphin : IAnimal {

        public IFeedBehaviour FeedBehaviour { get; set; }
        public ISleepBehaviour SleepBehaviour { get; set; }

        public void Sleep() {
            SleepBehaviour.Do();
        }

        public void Feed() {
            FeedBehaviour.Do();
        }

    }


    public enum AnimalTypeEnum { 
        Cat,
        Dolphin,
        Sheep
    }

    public class AnimalController {


        // CLASS FACTORY
        public T Create<T>(AnimalTypeEnum animalType) where T : class, new(){

            IAnimal animal = Activator.CreateInstance(typeof(T)) as IAnimal;

            switch (animalType) {
                case AnimalTypeEnum.Cat:
                    animal = new Cat();
                    animal.FeedBehaviour = new OmnivoreFeedBehaviour();
                    animal.SleepBehaviour = new FullSleepBehaviour();
                    break;

                case AnimalTypeEnum.Dolphin:
                    animal = new Dolphin();
                    animal.FeedBehaviour = new CarnivoreFeedBehaviour();
                    animal.SleepBehaviour = new SemiSleepBehaviour();
                    break;

                case AnimalTypeEnum.Sheep:
                    animal = new Sheep();
                    animal.FeedBehaviour = new HerbivoreFeedBehaviour();
                    animal.SleepBehaviour = new FullSleepBehaviour();
                    break;
            }



            return (T)animal;
        }
    }

    public class MyClass<T> where T : new() {
        protected T GetObject() {
            return new T();
        }
    }

    public class Test {


        public void DoTest() { 

           
            AnimalController controller= new AnimalController();
            
            Cat cat = controller.Create<Cat>(AnimalTypeEnum.Cat);
        
        }
    
    }

}
