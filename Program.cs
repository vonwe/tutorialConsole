public class Program
{
    public static void Main(string[] args)
    {
        // inline comments
        /*block comments*/

        // console refers to terminal console
        // we have .ReadLine and .WriteLine methods
        Console.WriteLine("Please enter your name: ");

        // when creating a variable, declare the type
        string name;
        name = Console.ReadLine();  

        // we'll use concatenation to add strings
        Console.WriteLine("Hello, " + name + "!");

        // tell our code to run CoinFlip method
        CoinFlip();
    }

    public static void CoinFlip()
    {
        Console.WriteLine("CoinFlip starting...");
        // bool user = PlayerGuess();

        // boolean variables are noted by "bool"
        bool coin;

        // we'll have the compiler guess the outcome first
        string predict;

        // we can use a random no. generator
        Random rand = new Random(); // our first class object
        Random grand = new Random(); // our second class object

        int val = rand.Next(); // pull the next random number
        int guess = grand.Next(); // pulls random number for computer assumption

        int remainder = val % 2; // modulous operator (%) gives us remainder
        int prediction = guess % 2;

        if (prediction == 0) {
            predict = "heads";
        } else {
            predict = "tails";
        }

        if (remainder == 0) {
            coin = false;
        } else {
            coin = true;
        }

        Console.WriteLine("The house has chosen: " + predict);
        Console.WriteLine("The coin was flipped, and landed on: " + ((coin) ? "tails" : "heads") );
        // Console.WriteLine((coin == user) ? "Congratulations, you guessed right!" : "Sorry, you guessed wrong.")
    }
}