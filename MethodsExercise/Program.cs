using System.Diagnostics;

namespace MethodsExercise
{

    public class Program

        
    {
        //-----EXERCISE TWO----------------------

        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }

        public static int Sum(int num1, int num2, int num3)
        {
            var answer = num1 + num2 + num3;
            return answer;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            var amountOfDogs = Sum(2, 4);

            var amountOfCats = Multiply(10, 2);

            var amountOfBirds = Sum(6, 24, 13);

            var bagsOfPetFood = Sum(1, 1, 1, 1, 1);

            Console.WriteLine($" At Jim Bob's Pet Store & Supply, their current inventory is {amountOfDogs} puppies, {amountOfCats} cats, and {amountOfBirds} different types of birds.");
            Console.WriteLine($"They also have {bagsOfPetFood} bags of feed.  Yee-haw, y'all!");



            //-----EXERCISE ONE----------------------


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

