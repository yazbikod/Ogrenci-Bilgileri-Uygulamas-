using Öğrenci_Uygulaması;

bool kontrol = true;
Ogrenci ogrenci1 = new Ogrenci(1, "Murat", "Han", 68, 72, 95, "Salih Alptekin İÖO");
Console.WriteLine("Uygulamamıza Hoşgeldiniz....");


while (kontrol)
{
    islemleriGoster();

    string secim = Console.ReadLine();

    switch (secim)
    {
        case "1": ogrenci1.ogrenciBilgileri(); break;
        case "2":
            double ogrOrtalama = ogrenci1.ogrenciNotu();
            Console.WriteLine("Öğrenci Ortalaması : " + ogrOrtalama); break;
        case "3": ogrenci1.okulGetir(); break;
        case "4": kontrol = false; break;
    }


}

static void islemleriGoster()
{
    Console.WriteLine("1 - Öğrenci Bilgilerini Göster");
    Console.WriteLine("2 - Öğrenci Ortalamasını Göster");
    Console.WriteLine("3 - Öğrenci Okulunu Göster");
    Console.WriteLine("4 - Çıkış Yap");
}