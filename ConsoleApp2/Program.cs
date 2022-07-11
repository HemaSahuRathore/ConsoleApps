namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //HumanClass
            //HumanClass Riya = new HumanClass("Riya", 23, 5.2f);
            //HumanClass Piya = new HumanClass("Piya", 24, 5.1f);

            //Riya.DisplayDetails();
            //Piya.DisplayDetails();

            // //..........................................
            // //ReverseNumber Program

            //Console.Write("Please enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            ////Palindrome Program
            //ReverseNumber.MakeItReverse(number);
            //Console.ReadLine();

            Console.WriteLine("Please select from Below: \n1.Human \n2.Reverse Number \n3.Palindrome");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option) 
            {
                case 1:
                    HumanClass Riya = new HumanClass("Riya", 23, 5.2f);
                    HumanClass Piya = new HumanClass("Piya", 24, 5.1f);
                    Riya.DisplayDetails();
                    Piya.DisplayDetails();
                    break;

                case 2:
                    Console.Write("Please enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.MakeItReverse(number);
                    break;

                default:
                    Console.Write("Please enter a number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.MakeItReverse(number1);
                    Console.ReadLine();
                    break;

              
                  
                   

            }


        }
    }
}   