namespace CS
{
    public class Program
    {
        static void CheckTask1()
        {
            Builder builder = new Builder("Artem", 18);
            Console.WriteLine(builder.Build());
            Sailor sailor = new Sailor();
            Console.WriteLine(sailor.Sail());
            Pilot pilot = new Pilot();
            Console.WriteLine(pilot.Piloting());
        }
        static void CheckTask2()
        {
            ForeignPassport passport = new ForeignPassport("01/01/2023", "John Doe", new string[] { "USA", "UK", "Canada" }, "AB123456");
            Console.WriteLine(passport.ToString());
        }
        static void CheckTask3()
        {
            Crocodile crocodile = new Crocodile("Croco", "default crocodile");
            Console.WriteLine(crocodile.name);
            Console.WriteLine(crocodile.description);
        }
        static void CheckTask4()
        {
            Trapezium trapezium = new Trapezium(3, 5, 2);
            Console.WriteLine(trapezium.GetSquare());
        }
        static void Main()
        {
            //CheckTask1();
            //CheckTask2();
            //CheckTask3();
            CheckTask4();
        }
    }
}