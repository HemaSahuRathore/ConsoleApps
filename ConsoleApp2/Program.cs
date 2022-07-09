namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HumanClass
            //HumanClass Riya = new HumanClass("Riya", 23, 5.2f);
            //HumanClass Piya = new HumanClass("Piya", 24, 5.1f);

            //Riya.DisplayDetails();
            //Piya.DisplayDetails();

            //..........................................
            //ReverseNumber Program

            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            ReverseNumber.MakeItReverse(number);
            Console.ReadLine();
        }
    }
}   