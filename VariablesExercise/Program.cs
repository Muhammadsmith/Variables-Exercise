namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Ron";
            int number = 25;
            char choice = 'a';
            bool answer = true;
            double price = 100.99;
            decimal count = 10000000.9m;
            Console.WriteLine($"Hi, my name is {name} i am {number} years old.");
            Console.WriteLine($"{choice} {answer} statement about {name} is he spends {price} dollars a week on food.");
            Console.WriteLine($"{name} also hopes to make {count} this year.");
        }
    }
}
