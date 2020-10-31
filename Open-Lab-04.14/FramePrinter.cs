using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            string frame = "";
            int hey = 0;

            foreach (string sup in strings)
            {
                if (hey < sup.Length)
                    hey = sup.Length;
            }

            for (int i = 0; i < hey + 4; i++)
            {
                frame += "*";
            }

            Console.WriteLine(frame);

            foreach (string sup in strings)
            {
                if (sup.Length < hey)
                {
                    string str = "";
                    for (int i = 0; i < hey - sup.Length; i++)
                    {
                        str += " ";
                    }
                    Console.WriteLine("* " + sup + str + " *");
                }
                else
                    Console.WriteLine("* " + sup + " *");
            }

            Console.WriteLine(frame);
        }
    }
}