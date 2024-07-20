

Console.WriteLine("Zırva Tatil Planlamaya Hoşgeldiniz!\nTatil lokasyonlarımız ve ortalama fiyatlarımız şu şekildedir:\n");

// Burada daha sonra kullanacağım değişkenlerin tanımlamasını yapıyorum ve boş değer atıyorum.
string place = "";
string tripDecision;
string wayOfTransportation = "";
string transportationDecision;
string anotherDecision = "";
int costPerPerson = 0;
int costOfTransportation = 0;

do // Programda en sorduğum soruya göre başa atmak için do-while döngüsü kullandım.
{

    do // Kullanıcı gitmek istediği yerlerden birini yazmadığı sürece bu döngü devam edecek.
    {
        Console.WriteLine("-----Bodrum -> Paket başlangıç fiyatımız 4000 TL");
        Console.WriteLine("-----Marmaris -> Paket başlangıç fiyatımız 3000 TL");
        Console.WriteLine("-----Çeşme -> Paket başlangıç fiyatımız 5000 TL\n");

        Console.Write("Lütfen gitmek istediğiniz yeri yazınız: ");
        tripDecision = Console.ReadLine().ToLower();

        // Kullanıcıdan girilen değere göre değişecek fiyatlandırma için burada atama yapıyorum if-else yapısını kullanarak.
        if (tripDecision == "bodrum")
        {
            place = "Bodrum";
            costPerPerson = 4000;
        }
        else if (tripDecision == "marmaris")
        {
            place = "Marmaris";
            costPerPerson = 3000;
        }
        else if (tripDecision == "çeşme")
        {
            place = "Çeşme";
            costPerPerson = 5000;
        }
        else
        {
            Console.WriteLine("\nBahsettiğiniz lokasyona programımız bulunmamaktadır. Lütfen Zırva'nın belirttiği yerlerden birini seçiniz.\n");
        }
    } while (tripDecision != "bodrum" && tripDecision != "marmaris" && tripDecision != "çeşme");

    // Burada kullanıcının sayı gireceğini düşünerek böyle bıraktım buraya da bir kontrol yapısı kurulabilirdi.
    Console.Write("\nLütfen tatile kaç kişi gideceğinizi sayıyla belirtiniz: ");
    int numberOfPeople = Convert.ToInt32(Console.ReadLine());

    // Burada yaptığı seçimle ve tatille ilgili ufak bir özet yazdırıyor.
    Console.WriteLine($"\nTatil için seçtiğiniz yer {place}. Buradayken deniz sporları yapabilir ve dilerseniz koy turlarına katılabilirsiniz.\n");

    do // Kullanıcı burada ulaşım yolunu seçiyor. Program duruma göre tekrar soracak yapıda kurulu.
    {
        Console.WriteLine("Tatile ne şekilde gitmek istersiniz? Seçeneklerimiz şunlardır:\n");
        Console.WriteLine("1-) Kara yolu (Kişi başı ulaşım gidiş-dönüş 1500 TL)\n");
        Console.WriteLine("2-) Hava yolu (Kişi başı ulaşım gidiş-dönüş 4000 TL)\n");
        Console.Write("Lütfen yukarıdaki seçeneklerden birini seçiniz. 1 ya da 2 yazarak seçim yapabilirsiniz: ");
        transportationDecision = Console.ReadLine();

        switch (transportationDecision)
        {
            case "1":
                costOfTransportation = 1500;
                wayOfTransportation = "Kara yolu";
                break;
            case "2":
                costOfTransportation = 4000;
                wayOfTransportation = "Hava yolu";
                break;
            default:
                Console.WriteLine("\nIşınlanmak gibi bir teknolojimiz olsaydı onu da seçenekler arasına koyardık. Lütfen var olan ulaşım seçeneklerinden birini seçiniz.\n");
                break;
        }
    } while (transportationDecision != "1" && transportationDecision != "2");

    // Burada kullanıcının yaptığı seçimlerden sonra tatilin maliyetini konsola yazdırıyoruz.
    Console.WriteLine($"\n{wayOfTransportation}yla gidilecek {numberOfPeople} kişilik {place} tatili size toplamda {numberOfPeople * (costPerPerson + costOfTransportation)} TL'ye patlayacak.");

    // Burada yeni bir tatil planlaması yapmak isteyip istemediği soruluyor. Duruma göre başa atacak ya da program kendini sonlandıracak.
    Console.WriteLine("\nBaşka bir tatil planlaması daha yapmak ister misiniz?\n");
    anotherDecision = Console.ReadLine().ToLower();

    if (anotherDecision == "evet")
    {
        Console.WriteLine("\nSizi başa yolluyorum...\n");
    }
    else if (anotherDecision == "hayır")
    {
        Console.WriteLine("\nBen de öyle düşünmüştüm bu ekonomide başka bir tatil daha planlamak çok zor, iyi günler!");
    }
    else
    {
        Console.WriteLine("\nBu sefer dediğinizi anlamaya çalışmayacağım, iyi günler!");
    }
} while (anotherDecision == "evet");