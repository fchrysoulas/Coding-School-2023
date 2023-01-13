using Session_05;

internal class Program {

    private static void Main(string[] args) {


        Console.WriteLine("Select n");
        Console.Clear();


        string s = Console.ReadLine();

        Console.WriteLine("1. Sum");
        Console.WriteLine("2. Product");

        s = Console.ReadLine();


        Class1 c = new Class1();

        ushort k = (ushort)c.Add(5, 2);

        //if (true) {

        //    int j = Convert.ToInt32(s);

        //    for (int i = 0; i < j; i++) {

        //    }

        //}


    }
}