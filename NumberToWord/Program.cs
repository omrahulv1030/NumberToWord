namespace NumberToWord
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            
            Console.WriteLine("Enter number");
            try
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine(Converter.ConvertNumber(number));               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.ReadKey();       }


         

      
    }
}
