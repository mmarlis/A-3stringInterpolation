using System.Runtime.Intrinsics.X86;

namespace A_3stringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var date = DateTime.Now;

            Console.WriteLine($"{date,40:MMMM d, yyyy}"); //January 22, 2019 (right aligned in a 40 character field)

            Console.WriteLine($"{date:yyyy.MM.dd}"); //2019.01.22

            Console.WriteLine($"Day{date: dd 'of' MMMM, yyyy}"); //Day 22 of January, 2019

            Console.WriteLine($"Year: {date:yyyy}, Month: {date:MM}, Day: {date: dd}");//Year: 2019, Month: 01, Day: 22

            Console.WriteLine($"{date,10:dddd}"); //          Tuesday (10 spaces total, right aligned)

            Console.WriteLine($"{date,10:h:mm tt} {date,10:dddd}"); //; 11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)

            Console.WriteLine($"{date:'h:'h, 'm:'mm, 's:'ss}"); //h:11, m:01, s:27

            //2019.01.22.11.01.27

             var pi = Math.PI;

             Console.WriteLine(String.Format("{0:C}", pi)); //$3.14

             //-------------------------------------------------------------------------------------------------------
             
             //Lynn's example:

             Console.WriteLine($"|{"Left",-7}|{"Right",7}|");
             // Expected output is:
             // |Left   |  Right|

             const int FieldWidthRightAligned = 20;
             Console.WriteLine($"{Math.PI,FieldWidthRightAligned} - default formatting of the pi number");
             Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");
             //     3.14159265358979 - default formatting of the pi number
             //

        }
    }
}