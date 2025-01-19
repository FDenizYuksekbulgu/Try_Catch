using System;


class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Lütfen bir sayı giriniz: "); //Kullanıcıdan giriş alınır.

                //Kullanıcının girdiği değeri okuyup sayıya çeviririz.
                string input = Console.ReadLine();
                double sayi = Convert.ToDouble(input);

                //Sayının karesini hesaplarız ve ekrana yazdırırız.
                Console.WriteLine($"Girdiğiniz sayının karesi: {sayi * sayi}");
                break; //Geçerli bir giriş sağlandığında döngüden çıkar.
            }
            catch (FormatException)
            {
                //Hatalı bir giriş durumunda uyarı mesajı verir.
                Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir sayı giriniz.");
            }
        }
    }
}
