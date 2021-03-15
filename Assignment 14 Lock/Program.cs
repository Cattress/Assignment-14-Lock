using System;

namespace Assignment_14_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            ComboLock c1 = new ComboLock();
            c1.OpenCombo(0252);
            Console.WriteLine(c1.isLocked());

            string input = Console.ReadLine();
            int userInput = Convert.ToInt32(input);
            c1.ChangeCode(userInput);

            userInput = 0;
            input = Console.ReadLine();
            userInput = Convert.ToInt32(input);
            c1.OpenCombo(userInput);
            Console.WriteLine(c1.isLocked());
        }

        //extension == create time delay lock class that locks 5 secs after unlocking
        //thread
    }
}
