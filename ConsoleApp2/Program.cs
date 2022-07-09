namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanClass Riya = new HumanClass("Riya", 23, 5.2f);
            HumanClass Piya = new HumanClass("Piya", 24, 5.1f);

            Riya.DisplayDetails();
            Piya.DisplayDetails();
        }
    }
}   