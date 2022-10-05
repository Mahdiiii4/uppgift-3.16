using System;
namespace uppgift3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt är den låt? Ange först minuter sen sekunder");
            Console.WriteLine("Hur mycket minuter?");
            int minut = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket sekonder?");
            int sekunder = int.Parse(Console.ReadLine());
            int minutX = minut * 60;
            int minutXsekund = sekunder + minutX;
           
            if (minutXsekund < 165)
                Console.WriteLine("Den låt för tyvvär inte spelas på radiostationen eftersom den är för kort");

            else if (minutXsekund > 260)
                Console.WriteLine("Den låt för tyvvär inte spelas på radiostationen eftersom den är för långt");

            else if (minutXsekund > 165 && minutXsekund < 260)
                Console.WriteLine("Den låt för spelas på radiostationen!");

        }
    }
}