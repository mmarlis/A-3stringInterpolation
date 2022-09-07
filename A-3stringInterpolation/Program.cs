using System.Runtime.Intrinsics.X86;

namespace A_3stringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var date = DateTime.Now;
            DateTime today = DateTime.Now;

            Console.WriteLine($"{date,40:MMMM d, yyyy}"); //Month date, year (right aligned in a 40 character field)

            Console.WriteLine($"{date:yyyy.MM.dd}"); //year.mo.day

            Console.WriteLine($"Day{date: dd 'of' MMMM, yyyy}"); //Day date of month, year

            Console.WriteLine($"Year: {date:yyyy}, Month: {date:MM}, Day: {date: dd}");//Year: yyyy, Month: mm, Day: dd

            Console.WriteLine($"{date,10:dddd}"); //          day of the week  (10 spaces total, right aligned)

            Console.WriteLine($"{date,10:h:mm tt} {date,10:dddd}"); //; time 00:00 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)

            Console.WriteLine($"{date:'h:'h, 'm:'mm, 's:'ss}"); //h:00, m:00, s:00


            Console.WriteLine($"{today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");//yyyy.mo.dd.h.m.s

            var pi = Math.PI;

             Console.WriteLine(String.Format("{0:C}", pi)); //$3.14

             //-------------------------------------------------------------------------------------------------------
             
             //Lynn's example:

             //Console.WriteLine($"|{"Left",-7}|{"Right",7}|");
             // Expected output is:
             // |Left   |  Right|

            // const int FieldWidthRightAligned = 20;
             //Console.WriteLine($"{Math.PI,FieldWidthRightAligned} - default formatting of the pi number");
             //Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");
            //     3.14159265358979 - default formatting of the pi number
            //





        }
    }
}