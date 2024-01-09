namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //methods returning info about user

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userFavoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userFavoriteBand = Console.ReadLine();

            Console.WriteLine($"There was a person named {userName}. Their favorite color is {userFavoriteColor}.");
            Console.WriteLine($"{userName}'s favorite animal is a {userFavoriteAnimal}.");
            Console.WriteLine($"{userName} likes to listen to {userFavoriteBand}.");


            //methods returning mathmatical answers from users input

            //add
            Console.WriteLine("Give me a number to add.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to add to the first number.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}.");


            //subtract
            Console.WriteLine("Give me a number to subtract.");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to subtract from the first number.");
            int num4 = int.Parse(Console.ReadLine());

            int difference = Subtract(num3, num4);
            Console.WriteLine($"The difference is {difference}.");

            //multiply
            Console.WriteLine("Give me a number to multiply.");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to multiply to the first number.");
            int num6 = int.Parse(Console.ReadLine());

            int product = Multiply(num5, num6);
            Console.WriteLine($"The product is {product}.");

            //divide
            Console.WriteLine("Give me a number to divide.");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to divide into the first.");
            int num8 = int.Parse(Console.ReadLine());

            int divisible = Divide(num7, num8);
            Console.WriteLine($"{num8} goes into {num7} {divisible} times.");

            //modulus
            Console.WriteLine("Give me a number for the Modulus operator.");
            int num9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a second number for the Modulus operator.");
            int num10 = int.Parse(Console.ReadLine());

            int modulus = Modulus(num9, num10);
            Console.WriteLine($"The remainder for the modulus is {modulus}.");

        }

        public static int Sum(int num1, int num2)
        {
            //int sum = num1 + num2;

            //return sum;

            return num1 + num2;
        }


        public static int Subtract(int num3, int num4)
        {
            return (num3 - num4);
        }


        public static int Multiply(int num5, int num6)
        {
            return num5 * num6;
        }

        public static int Divide(int num7, int num8)
        {
            return num7 / num8;
        }

        public static int Modulus(int num9, int num10)
        {
            return num9 % num10;
        }

    }
}
