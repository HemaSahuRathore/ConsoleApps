using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HumanClass
    {
        public string name;
        public int age;
        public float height;

        public void Walk()
        {
            Console.WriteLine("Human can walk");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name:" + name + " Age: " + age + " Height: " + height);
            Console.ReadLine();
        }


        public HumanClass(string humanName, int humanAge, float humanHeight)
        {
            name = humanName;
            age = humanAge;
            height = humanHeight;

        }

    }

}
