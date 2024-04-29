namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("Great pick! Now please tell me your favorite animal.");
            var animal = Console.ReadLine();

            Console.WriteLine("Nice choice.  One last question, and then I will write a story for you using your answers.  What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{name} went to the store to buy a {color} tshirt with {animal}s printed on it. {name} will be wearing that shirt to the {band} concert tonight!");
        }
    }
}
