using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ranglar uchun enum yarating hamda quyidagicha
            //informatsiyalarni console ga chiqaring.
            //RED at index 0
            //GREEN at index 1
            //BLUE at index 2
            foreach (var item in Enum.GetValues(typeof(Ranglar)))
            {
                Console.WriteLine(item + " at index " + (int)item);
            }
        }
    }
    enum Ranglar
    {
        RED = 0,
        GREEN = 1,
        BLUE = 2,
        ORANGE = 3,
        WHITE = 4,
    }
}