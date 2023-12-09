using System;

class Program
{
    static void Main()
    {
     
            Console.Write("İlk sayıyı girin: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.Write("TEK'leri mi ÇİFT'leri mi toplamak istersiniz? (T/Ç): ");
            char tercih = char.ToUpper(Console.ReadLine()[0]);

            int toplam = 0;

            switch (tercih)
            {
                case 'T':
                    for (int i = sayi1; i <= sayi2; i++)
                    {
                        if (i % 2 == 1) //kalan 1se topla
                        {
                            toplam += i;
                        }
                    }
                    Console.WriteLine($"{sayi1} ile {sayi2} arasındaki TEK sayıların toplamı: {toplam}");
                    break;

                case 'Ç':
                    for (int i = sayi1; i <= sayi2; i++)
                    {
                        if (i % 2 == 0)
                        {
                            toplam += i; //kalan sıfır ise topla
                        }
                    }
                    Console.WriteLine($"{sayi1} ile {sayi2} arasındaki ÇİFT sayıların toplamı: {toplam}");
                    break;

                default:

                    Console.WriteLine("Geçersiz");
                    break;
            }
        
       

        Console.ReadKey();
    }
}
