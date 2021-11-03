using System;

namespace döngüler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            int girdi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= girdi; i++)
            {
                if (i%2 == 1)
                    Console.WriteLine(i);
            
                    
                
            }
            //1 ile 1000 arasındaki  tek ve çift sayıların kendi içlerinde toplamını ekrana yazdır
            int tektoplam = 0 ;
            int cifttoplam = 0 ;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==1)
                {
                    tektoplam += i; //tektoplam = tektoplam + i;
                }
                if (i%2 == 0) // veya else de tanımlanabilir çünkü tek değilsekesinlikle çifttir
                {
                    cifttoplam += i ; 
                }
            } 
            Console.WriteLine("tek toplam: "+ tektoplam );
            Console.WriteLine("çift toplam: "+ cifttoplam );

            // break ve continue

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break; // 3 ten sonra döngü devam etmez 4 e kadar yazdırır
                }
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                   continue; // 4 ü atlar geri kalanları yazdırır
                }
                Console.WriteLine(i);
            }



        } 

    }
}
