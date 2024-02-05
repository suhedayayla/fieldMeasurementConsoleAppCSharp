// See https://aka.ms/new-console-template for more information

namespace myConsoleApp{
    class Program{
        static void Main(string[] args)
        {
            int secim;

            do{
            MenuYaz();
            bool result;
            do{
                Console.Write("Seçiminiz: ");
                string secimStr = Console.ReadLine();
                result = int.TryParse(secimStr,out secim); //dönüştürmeyi dene ve dönüştürdüğün değeri secim değişkeninin içine at
                IslemYap(secim);

            } while (result==false);
            }while (secim!=0);

            secim =int.Parse(Console.ReadLine());

            static void IslemYap(int secim){
            switch(secim){
                case 1:
                //kare alanı
                KareAlanHesaplama();
               
                break;

                case 2:
                //dikdörtgen alanı
                DikdörtgenAlanHesaplama();
                break;

                case 3:
                //üçgen alanı
                UcgenAlanHesaplama();
                break;

                case 4:
                //yamuk alanı
                YamukAlanHesaplama();
                break;


            }
            }

        }
        

        static void MenuYaz(){
            Console.Clear();
            EkranaBaslikYaz("Alan Hesaplama Uygulaması");
            Console.WriteLine();

            EkranaBaslikYaz("Menü");
            Console.WriteLine("1) Kare Alanı Hesapla");
            Console.WriteLine("2) Dikdörtgen Alanı Hesapla");
            Console.WriteLine("3) Üçgen Alanı Hesapla");
            Console.WriteLine("4) Yamuk Alanı Hesapla");
            Console.WriteLine("0) Çıkış");
            Console.WriteLine();


        }
    static void EkranaBaslikYaz(string baslik){
        Console.WriteLine(baslik);
        for (int i=0; i<baslik.Length;i++){
            Console.Write("-");
        }
        Console.WriteLine();
    }

    static void DevamUyarisi(){
                Console.WriteLine();
                Console.WriteLine("Lütfen devam etmek için bir tuşa basın.");
                Console.ReadKey();

    }
    static void KareAlanHesaplama(){
                Console.Clear();
                EkranaBaslikYaz("Kare Alan Hesaplama");
                Console.Write("Lütfen a kenar uzunluğunu giriniz (cm): ");
                int a= int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Kare Alanı: " + (a*a) + " cm");
                DevamUyarisi();

    }
    static void DikdörtgenAlanHesaplama(){
                Console.Clear();
                EkranaBaslikYaz("Dikdörtgen Alan Hesaplama");
                Console.Write("Lütfen a kenar uzunluğunu giriniz (cm): ");
                int a= int.Parse(Console.ReadLine());

                Console.Write("Lütfen b kenar uzunluğunu giriniz (cm): ");
                int b= int.Parse(Console.ReadLine());


                Console.WriteLine();
                Console.WriteLine("Dikdörtgen Alanı: " + (a*b) + " cm");
                
                DevamUyarisi();

    }static void UcgenAlanHesaplama(){
                 Console.Clear();
                EkranaBaslikYaz("Üçgen Alan Hesaplama");
                Console.Write("Lütfen yükseklik uzunluğunu giriniz (cm): ");
                int a= int.Parse(Console.ReadLine());

                Console.Write("Lütfen taban kenar uzunluğunu giriniz (cm): ");
                int b= int.Parse(Console.ReadLine());

                double result2 = (Convert.ToDouble(a)*Convert.ToDouble(b))/2;

                Console.WriteLine();
                Console.WriteLine("Üçgen Alanı: " + result2 + " cm");
                DevamUyarisi();


    }static void YamukAlanHesaplama(){
                Console.Clear();
                EkranaBaslikYaz("Yamuk Alan Hesaplama");
                Console.Write("Lütfen yükseklik uzunluğunu giriniz (cm): ");
                int a= int.Parse(Console.ReadLine());

                Console.Write("Lütfen alt taban kenar uzunluğunu giriniz (cm): ");
                int b= int.Parse(Console.ReadLine());
                Console.Write("Lütfen üst taban kenar uzunluğunu giriniz (cm): ");
                int c= int.Parse(Console.ReadLine());

                double sub=(Convert.ToDouble(b)+Convert.ToDouble(c)) /2d;
                double result = sub*Convert.ToDouble(a);

                Console.WriteLine();
                Console.WriteLine("Yamuk Alanı: " + result + " cm");
                DevamUyarisi();



    }
    }
}