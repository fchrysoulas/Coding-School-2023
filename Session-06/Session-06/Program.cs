// See https://aka.ms/new-console-template for more information

using Session_06;
using System.Net.Http.Headers;

internal class Program {
    
    private static void Main(string[] args) {

        //Display display = new Display();
        //display.Do();

        // person
        Person fotis = new Person();
        fotis.Name = "Fotis";
        fotis.ID = Guid.NewGuid();
        fotis.Age = 44;

        Person alex = new Person() {
            Age = 25,
            ID = Guid.NewGuid(),
            Name = "Alex"
        };

        Person anestis = new Person(Guid.NewGuid(), "Anestis");
        anestis.Age = 25;


        //Entity blob = new Entity()
        //blob.Name = "blob";


        //Student[] students = new Student[2];

        //Student alex = new Student();
        //students[0] = alex;

        //Student anestis = new Student();
        //students[1] = anestis;
        int length = 10;

        for (int i = 0; i < length; i++) {

            try {

                University uni = new University();

                if (uni.Students[i] != null) {

                    Console.WriteLine(uni.Students[0].Name);
                }
                else {
                    Console.WriteLine("We dont have any students!");
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            finally {
                Console.WriteLine("--------");

            }
        }
        


        Console.ReadLine();



    }
}