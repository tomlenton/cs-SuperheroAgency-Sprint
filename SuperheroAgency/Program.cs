namespace SuperheroAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[] intArray = { 1, 5, 2, 8, 6 };
            //    Console.WriteLine(GetLast(intArray)); // 6

            //    double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
            //    Console.WriteLine(GetLast(doubleArray)); // 6.1111

            //    string[] stringArray = { "hello", "world", "it's", "northcoders!" };
            //    Console.WriteLine(GetLast(stringArray)); // "northcoders!"

            //    Stack<string> stack = new Stack<string>();
            //    stack.Push("The Perfume");
            //    stack.Push("Death and the Penguin");
            //    stack.Push("Dune");
            //    stack.Pop();
            //    Console.WriteLine($"Number of elements: {stack.Count}");
            //    foreach (string book in stack)
            //    {
            //        Console.WriteLine(book);
            //    }
            //    var myBooks = new CustomStack<string>();

            //    myBooks.Push("Book 1");
            //    myBooks.Push("Book 2");
            //    myBooks.Push("Book 3");

            //    Console.WriteLine(myBooks.Pop()); // Book 3

            //}
            //public static T GetLast<T>(T[] array) => array[array.Length - 1]; 
            var strandedCat = new RescueMission<IFly>("tree", 50);
            var bugInMyCode = new RescueMission<ITech>("zoom", 1000);
            var armWrestlingCompetition = new CombatMission<IStrength>("beach", 20);

            var reyzhen = new Mystic("Michael", "Reyzhen", 7000, Alignment.GOOD);
            strandedCat.HeroesDeployed.Add(reyzhen); // All good

            var rich = new Gadgeteer("Rich", "The Developer", 33, Alignment.EVIL);

            var survey1 = new ReconMission<Gadgeteer>("Leeds", 300); // Should provide an error

            var survey2 = new ReconMission<Mystic>("Manchester", 300);

            survey2.HeroesDeployed.Add(reyzhen); // All good
            survey2.HeroesDeployed.Add(rich); // Should provide an error
        }
    }
}
