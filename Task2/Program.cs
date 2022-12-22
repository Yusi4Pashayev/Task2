namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.Daxil edilən 4 rəqəmli ədədin rəqəmləri cəmini hesablayın.(4 ədəd daxil edilməyibsə false çap olunsun)

            
            
            while (true)
            {   Console.WriteLine("Dord reqemli eded daxil edin:");
                int a = int.Parse(Console.ReadLine());
                if (a >= 1000 && a <= 9999)
                {
                    int Rfirst = a % 10;
                    int Rsecond = ((a - Rfirst) % 100) / 10;
                    int Rthird = ((a - Rfirst - Rsecond * 10) % 1000) / 100;
                    int RFourth = (a - Rfirst - Rsecond * 10 - Rthird * 100) / 1000;
                    Console.WriteLine(Rfirst + Rsecond + Rthird + RFourth);

                }
                else Console.WriteLine("4 reqemli eded deyil");
            }
            
            
        }
    }
}