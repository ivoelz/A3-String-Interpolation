using System;

namespace A3_String_Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From today's date:");

            DateTime today = DateTime.Now;
            //January 22, 2019
            Console.WriteLine($"1. {today:MMMM} {today:dd}, {today:yyyy}");
            //2019.01.22
            Console.WriteLine($"2. {today:yyyy}.{today:MM}.{today:dd}");
            //Day 22 of January, 2019
            Console.WriteLine($"3. Day {today:dd} of {today:MMMM}, {today:yyyy}");
            //Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"4. Year: {today:yyyy}, Month: {today:MM}, Day: {today:dd}");
            //            Tuesday (10 spaces)
            Console.WriteLine($"5.          {today:dddd}");
            //     11:01 PM             Tuesday (10 spaces between)
            Console.WriteLine($"6.    {today:hh}:{today:mm} {today:tt}          {today:dddd}");
            //h:11, m:01, s:27
            Console.WriteLine($"7. h:{today:hh}, m:{today:mm}, s:{today:ss}");
            //2019.01.22.11.01.27
            Console.WriteLine($"8. {today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");

            Console.WriteLine("");
            Console.WriteLine("If you have PI(3.1415)");
            double pi = Math.PI;

            //Output pi as currency
            var piFormat = String.Format("{0:C}", pi);
            Console.WriteLine($"1. " + piFormat);

            //Output pi as right-aligned (10 spaces), number with 3 decimal places
            var piRight = String.Format("{0:0.###}", pi);
            Console.WriteLine(String.Format("{0,-10} {1,-10}", "2.", piRight + "\n"));
        }
    }
}
