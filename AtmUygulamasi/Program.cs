namespace AtmUygulamasi
{
    internal class Program
    {

        
        static void Main(string[] args)

        {

            decimal bakiye = 1000.0m;

            while (true)
            {
                Console.WriteLine("ATM Simülasyonu");
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Bakiye Görüntüleme");
                Console.WriteLine("4. Çıkış");
                Console.Write("Lütfen bir işlem seçin (1-4): ");

                decimal secim = decimal.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    ParaCekme(bakiye);
                }
                else if (secim == 2)
                {
                    ParaYatirma(bakiye);
                }
                else if (secim == 3)
                {
                    BakiyeGoruntuleme(bakiye);
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                }


            }

        }




        public static decimal ParaCekme(decimal bakiye)
        {
            Console.Write("Çekmek istediğiniz miktarı girin: ");
            decimal cekilenMiktar = decimal.Parse(Console.ReadLine());
            
            
                if (cekilenMiktar > 0 && cekilenMiktar <= bakiye)
                {
                    bakiye = cekilenMiktar;
                    Console.WriteLine($"Başarıyla {cekilenMiktar} TL çekildi. Güncel bakiye: {bakiye} TL");
                }
                else
                {
                    Console.WriteLine("Geçersiz miktar. Lütfen uygun bir miktar girin.");
                }
           
            return bakiye;
        }

        public static decimal ParaYatirma(decimal bakiye)
        {
            Console.Write("Yatırmak istediğiniz miktarı girin: ");
            decimal yatirilanMiktar= decimal.Parse(Console.ReadLine());
           
            
                if (yatirilanMiktar > 0)
                {
                    bakiye += yatirilanMiktar;
                    Console.WriteLine($"Başarıyla {yatirilanMiktar} TL yatırıldı. Güncel bakiye: {bakiye} TL");
                }
                else
                {
                    Console.WriteLine("Geçersiz miktar. Lütfen uygun bir miktar girin.");
                }
            return bakiye;
        }

        public static decimal BakiyeGoruntuleme(decimal bakiye)
        {
            Console.WriteLine($"Güncel bakiye: {bakiye} TL");
            return bakiye;
        }
    }
    
}
