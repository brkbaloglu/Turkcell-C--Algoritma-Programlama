// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Write("Murat");
//Console.Write("Yücedağ");
//Console.Write("Fırat Üniversitesi");
//Console.Write("Elazığ");

//string sehir, ilce;
//sehir = "İstanbul";
//ilce = "Şişli";
//Console.WriteLine(sehir + "-" + ilce);

//int sayi1, sayi2, toplam;
//sayi1 = 12;
//sayi2 = 25;
//toplam = sayi1 + sayi2;
//Console.WriteLine(toplam);


//int s1, s2, toplam, carpim, bolum, fark;
//s1 = 20;
//s2 = 3;
//toplam = s1 + s2;
//fark = s1 - s2;
//carpim = s1 * s2;
//bolum = s1 / s2;
//Console.WriteLine("Toplam: " + toplam);
//Console.WriteLine("Fark: " + fark);
//Console.WriteLine("Çarpım: " + carpim);
//Console.WriteLine("Bölüm: " + bolum);

//string ad, soyad, bolum, ders;
//int s1, s2, s3, ort;

//ad = "Murat";
//soyad = "Yücedağ";
//bolum = "Yazılım Mühendisliği";
//ders = "Algoritma Programlama";

//s1 = 65;
//s2 = 70;
//s3 = 88;
//ort = (s1 + s2 + s3) / 3;


//Console.WriteLine("Öğrenci Ad Soyad: " + ad + " " + soyad);
//Console.WriteLine("Bölüm: " + bolum);
//Console.WriteLine("Ders: " + ders);
//Console.WriteLine("Sınav 1: " + s1);
//Console.WriteLine("Sınav 2: " + s2);
//Console.WriteLine("Sınav 3: " + s3);
//Console.WriteLine("Ortalama: " + ort);


//double sayi = 24.9;
//Console.WriteLine(sayi);

//double s1 = 78, s2 = 85, ort = (s1 + s2) / 2;
//Console.WriteLine(ort);


//string sehir, ilce;
//Console.WriteLine("Lütfen şehrinizi giriniz.");
//sehir = Console.ReadLine();

//Console.WriteLine("Lütfen ilçenizi giriniz.");
//ilce = Console.ReadLine();


//Console.WriteLine("Şehir ve ilçe: " + sehir + " " + ilce);


//int sayi;
//Console.Write("Sayıyı giriniz: ");
//sayi = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(sayi);

//int s1, s2, toplam;
//Console.Write("Sayı 1:");
//s1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Sayı 2:");
//s2 = Convert.ToInt32(Console.ReadLine());
//toplam = s1 + s2;
//Console.WriteLine(toplam);

//double sayi1, sayi2, toplam;
//Console.Write("Sayı1:");
//sayi1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Sayı2:");
//sayi2 = Convert.ToDouble(Console.ReadLine());
//toplam = sayi1 + sayi2;
//Console.WriteLine("Toplam: " + toplam);


//char degisken;
//degisken = 'a';
//Console.WriteLine(degisken);


//byte sayi1, sayi2, toplam;
//sayi1 = 24;
//sayi2 = 36;
//toplam = Convert.ToByte(sayi1 + sayi2);
//Console.WriteLine(toplam);

//byte s1, s2, carpim;
//Console.Write("Sayı1:");
//s1 = Convert.ToByte(Console.ReadLine);
//Console.Write("Sayı2:");
//s2 = Convert.ToByte(Console.ReadLine);
//carpim = Convert.ToByte(s1 * s2);
//Console.WriteLine(carpim);

//sbyte sayi = 123;
//Console.WriteLine(sayi);

//sbyte sayi2;
//Console.Write("Sayıyı giriniz.");
//sayi2 = Convert.ToSByte(Console.ReadLine);

//sbyte s1, s2, toplam;
//Console.Write("Sayı1:");
//s1 = Convert.ToSByte(Console.ReadLine);
//Console.Write("Sayı2:");
//s2 = Convert.ToSByte(Console.ReadLine);
//toplam = Convert.ToSByte(s1 + s2);

//Console.WriteLine(toplam);

//float sayi = 345.65f;
//Console.WriteLine(sayi);

//float s1, s2, toplam;
//Console.WriteLine("Sayı1:");
//s1 = float.Parse(Console.ReadLine());
//Console.WriteLine("Sayı2:");
//s2 = float.Parse(Console.ReadLine());
//toplam = s1 + s2;
//Console.WriteLine(toplam);

//Console.WriteLine(byte.MaxValue);
//Console.WriteLine(byte.MinValue);
//Console.WriteLine(int.MaxValue);
//Console.WriteLine(int.MinValue);
//Console.WriteLine(float.MaxValue);
//Console.WriteLine(float.MinValue);
//Console.WriteLine(sbyte.MinValue);
//Console.WriteLine(sbyte.MinValue);

//short s1 = 650, s2 = 3456, toplam = (short)(s1 + s2);
//Console.WriteLine(toplam);

//short a, b, c;
//Console.Write("A:");
//a = short.Parse(Console.ReadLine());
//Console.Write("B:");
//b = short.Parse(Console.ReadLine());
//c = Convert.ToInt16(a + b);
//Console.WriteLine(c);

//ushort sayi1 = 34, sayi2 = 56, toplam = (ushort)(sayi1 + sayi2);
//Console.WriteLine(toplam);


//ushort kenar1, kenar2, alan, cevre;
//Console.WriteLine("Kısa kenarı giriniz: ");
//kenar1 = ushort.Parse(Console.ReadLine());
//Console.WriteLine("Uzun kenarı giriniz: ");
//kenar2 = ushort.Parse(Console.ReadLine());

//alan = (ushort)(kenar1 * kenar2);
//cevre = (ushort)(2 * (kenar1 + kenar2));
//Console.WriteLine("Alan: " + alan + ", Çevre: " + cevre);


//decimal sayi1 = 20, sayi2 = 12, fark = sayi1 - sayi2;
//Console.WriteLine(fark);

//decimal kenar, alan, cevre;
//Console.Write("Kenarı giriniz:");
//kenar = Convert.ToDecimal(Console.ReadLine);
//alan = kenar * kenar;
//cevre = 4 * kenar;
//Console.Write("Alan: " + alan + ", Çevre: " + cevre);

//decimal sayi = 4.56m;
//Console.WriteLine(sayi);

//bool durum = true;
//Console.WriteLine("Öğrenci sınavı geçti mi?");
//Console.WriteLine(durum);


//bool uyemi;
//Console.Write("Kullanıcı sisteme üye mi? ");
//uyemi = Convert.ToBoolean(Console.ReadLine);
//Console.WriteLine("Kullanıcının sisteme üyelik durumu: " + uyemi);


//string sehir;
//Console.WriteLine("Şehir Adı:");
//sehir = Console.ReadLine();
//if (sehir == "Adana")
//{
//    Console.WriteLine("Doğru şehir");
//}
//else
//{
//    Console.WriteLine("Yanlış şehir");
//}

//int sayi;
//Console.WriteLine("Sayıyı giriniz:");
//sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi == 23)
//{
//    Console.WriteLine("Doğru");
//}
//else
//{
//    Console.WriteLine("Yanlış");
//}

//int s1, s2, ort;
//Console.WriteLine("Sınav 1:");
//s1 = Convert.ToInt32(Console.ReadLine);
//Console.WriteLine("Sınav 2:");
//s2 = Convert.ToInt32(Console.ReadLine);
//ort = (s1 + s2) / 2;
//Console.WriteLine("Ortalama: " + ort);

//if (ort >= 50)
//{
//    Console.WriteLine("Geçtiniz");
//}
//else
//{
//    Console.WriteLine("Kaldınız");
//}

//string kullanici, sifre;
//Console.WriteLine("Kullanıcı adı:");
//kullanici = Console.ReadLine();
//Console.WriteLine("Şifre:");
//sifre = Console.ReadLine();

//if (kullanici == "admin" || sifre == "123456")
//{
//    Console.WriteLine("Hoşgeldiniz");
//}
//else
//{
//    Console.WriteLine("Hata");
//}



//int s1, s2, s3, ort;
//Console.WriteLine("Sınav 1:");
//s1 = Convert.ToInt32(Console.ReadLine);
//Console.WriteLine("Sınav 2:");
//s2 = Convert.ToInt32(Console.ReadLine);
//Console.WriteLine("Sınav 3:");
//s3 = Convert.ToInt32(Console.ReadLine);
//ort = (s1 + s2 + s3) / 3;
//Console.WriteLine("Ortalama: " + ort);


//if (ort <= 49)
//{
//    Console.WriteLine("Durum : Vasat");
//}

//if (ort >= 50 && ort <= 65)
//{
//    Console.WriteLine("Durum : Orta");
//}

//if (ort >= 66 && ort <= 79)
//{
//    Console.WriteLine("Durum : İyi");
//}

//if (ort >= 80 )
//{
//    Console.WriteLine("Durum : Çok İyi");
//}


//char karakter;
//Console.WriteLine("Karakteri giriniz:");
//karakter = Convert.ToChar(Console.ReadLine);

//if (karakter != 'a')
//{
//    Console.WriteLine("a karakteri girmediniz.");
//}
//else
//{
//    Console.WriteLine("a karakteri girdiniz.");
//}

//Console.WriteLine("Turkcell Bilgi Yarışması");
//Console.WriteLine("------------------------");
//string cevap;
//int soru = 1;
//if (soru == 1)
//{
//    Console.WriteLine("Türkiye'nin başkenti neresidir?");
//    Console.WriteLine("A) İstanbul");
//    Console.WriteLine("B) Ankara");
//    Console.WriteLine("C) İzmir");
//    Console.WriteLine("D) Bursa");
//    Console.WriteLine("Cevabınız: ");
//    cevap = Console.ReadLine();

//    if (cevap == "b" || cevap == "B")
//    {
//        Console.WriteLine("Doğru");
//    }
//    else
//    {
//        Console.WriteLine("Yanlış");
//    }
//}

//byte plaka;
//Console.WriteLine("Plaka giriniz:");
//plaka = Convert.ToByte(Console.ReadLine()); 

//switch (plaka)
//{
//    case 0:
//        Console.WriteLine("Adana");
//        break;
//    case 1:
//        Console.WriteLine("Adıyaman");
//        break; 
//    case 2:
//        Console.WriteLine("Afyon");
//        break;
//    default:
//        Console.WriteLine("Şehir bilgisi bulunamadı");
//        break;
//}

//Console.WriteLine("String değişkenler ile switch case uygulaması");
//string mevsim;
//Console.WriteLine("Mevsim:");
//mevsim = Console.ReadLine();
//switch (mevsim)
//{
//    case "yaz":
//        Console.WriteLine("Haziran - Temmuz - Ağustos");
//        break;
//    case "kış":
//        Console.WriteLine("Aralık - Ocak - Şubat");
//        break;
//    case "ilkbahar":
//        Console.WriteLine("Mart - Nisan - Mayıs");
//        break;
//    case "sonbahar":
//        Console.WriteLine("Eylül - Ekim - Kasım");
//        break;
//}


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Hello world");
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 20; i++)
//{
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int sayi;
//Console.WriteLine("Sayı:");
//sayi = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < 10; i++)
//{
//    if (sayi % i == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int bakteri = 1;
//for (int i = 0; i < 24; i++)
//{
//    bakteri *= 2;
//    Console.WriteLine(bakteri);
//}

//int sayi = 12;
//while (sayi <= 10)
//{
//    Console.WriteLine(sayi);
//    sayi++;
//}

//int sayi = 1;
//do
//{
//    Console.WriteLine(sayi);
//    sayi++;
//} while (sayi <= 10);

//Console.WriteLine("Int değişkenler ile dizi kullanımları");
//Console.WriteLine();
//int[] sayilar = { 10, 20, 30, 40, 50, 60, 70 };
//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (sayilar[i] % 20 == 0 || sayilar[i] % 30 == 0)
//    {
//        Console.WriteLine(sayilar[i]);
//    }
//}

//Console.WriteLine("Length kullanımı");
//string[] kisiler = { "ali", "veli", "ayşe", "ahmet", "eylül" };
//for (int i = 0; i < kisiler.Length; i++)
//{
//    Console.WriteLine(kisiler[i]);
//}
//Console.WriteLine(kisiler.Length);

//string[] sehirler = { "adana", "ankara", "zonguldak", "malatya", "elazığ", "bursa" };
//Array.Sort(sehirler);
//Array.Reverse(sehirler);
//for (int i = 0; i < sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}

//int[] sayilar = { 76, 43, 12, 56, 34 };
//Console.WriteLine("En küçük sayı:" + sayilar.Min());
//Console.WriteLine("En büyük sayı:" + sayilar.Max());

//int[] sayilar = { 23, 55, 32, 16, 89, 70 };
//int toplam = 0;
//foreach (int sayi in sayilar)
//{
//    toplam += sayi;
//}

//Console.WriteLine(toplam);

//int[] sayilar = { 34, 22, 11, 67, 89, 50 };
//foreach (var sayi in sayilar)
//{
//    if (sayi % 2 == 0)
//    {
//        Console.WriteLine(sayi);
//    }
////}


//string[] sehirler = new string[5];
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Şehir ismi:");
//    sehirler[i] = Console.ReadLine();
//}
//for (int j = 0; j < 5; j++)
//{
//    Console.WriteLine(sehirler[j]);
//}


//Console.Read();



//static void yazdir()
//{
//    Console.WriteLine("Bu bir metottur");
//}
//yazdir();

//static void topla()
//{
//    int sayi1 = 24, sayi2 = 30;
//    int toplam = sayi1 + sayi2;
//    Console.WriteLine(toplam);
//}
//topla();

//static void ardisiksayilar()
//{
//    for (global::System.Int32 i = 0; i < 10; i++)
//    {
//        Console.WriteLine(i);
//    }
//}
//ardisiksayilar();

//static void MetinYaz(string p)
//{
//    Console.WriteLine(p);
//}

//MetinYaz("deneme");
//string kelime = Console.ReadLine();
//MetinYaz(kelime);

//static int toplama()
//{
//    int sayi1 = 25, sayi2 = 35, sonuc = sayi1 + sayi2;
//    return sonuc;
//}

//Console.Write(toplama());

//static int toplam(int sayi1, int sayi2)
//{
//    int sonuc = sayi1 + sayi2;
//    return sonuc;
//}

//int sayi1, sayi2;
//Console.WriteLine("1. sayı:");
//sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2. sayı:");
//sayi2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(toplam(sayi1, sayi2));


//static int ortalama2(int s1, int s2)
//{
//    int sonuc = (s1 + s2) / 2;
//    return sonuc;
//}

//static int ortalama3(int s1, int s2, int s3)
//{
//    int sonuc = (s1 + s2 + s3) / 3;
//    return sonuc;
//}

//Console.WriteLine(ortalama2(1, 2));
//Console.WriteLine(ortalama3(1, 2, 3));

//Araba araba = new Araba();
//araba.marka = "Tesla";
//araba.model = "Y";
//araba.hiz = 100;
//araba.motor = 1.8;
//araba.renk = "beyaz";

//class Araba
//{
//    public string marka;
//    public string model;
//    public int hiz;
//    public double motor;
//    public string renk;
//}

//Musteri musteri = new Musteri();
//musteri.id = 1;
//musteri.name = "Murat";
//musteri.surname = "Yücedağ";
//musteri.city = "İstanbul";

//Musteri musteri = new Musteri();
//Console.WriteLine("Müşteri ID:");
//musteri.id = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Müşteri Ad:");
//musteri.name = Console.ReadLine();
//Console.WriteLine("Müşteri Soyad:");
//musteri.surname = Console.ReadLine();
//Console.WriteLine("Müşteri Şehir:");
//musteri.city = Console.ReadLine();

//class Musteri
//{
//    public int id;
//    public string name;
//    public string surname;
//    public string city;
//    public string Ad { get; set; }
//}

//Papagan papagan = new Papagan();
//papagan.tur = "Papağan";
//papagan.hiz = 50;
//papagan.isim = "Sultan";
//papagan.renk = "Sarı - Kırmızı";
//papagan.ses = "Cik";
//papagan.agirlik = 1650;

//class Kuslar
//{
//    public string tur;
//    public string ses;
//    public int hiz;
//    public double agirlik;
//    public virtual string sesCikar()
//    {
//        return " ";
//    }
//}

//class Papagan : Kuslar
//{
//    public string isim;
//    public string renk;
//    public override string sesCikar() 
//    {
//        return ses;
//    }
//}

//class Karga : Kuslar
//{
//    public string isim;
//    public string renk;
//    public override string sesCikar()
//    {
//        return ses;
//    }
//}

//double sayi;
//Console.WriteLine("Sayıyı giriniz:");
//sayi = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Mutlak değer: " + Math.Abs(sayi));
//Console.WriteLine("Üst taban: " + Math.Ceiling(sayi));
//Console.WriteLine("Alt taban: " + Math.Floor(sayi));
//Console.WriteLine("Karekök: " + Math.Sqrt(sayi));

//string metin, metin2;
//Console.WriteLine("Metin1:");
//metin = Console.ReadLine();
//Console.WriteLine("Metin2:");
//metin2 = Console.ReadLine();
//Console.WriteLine("Concat ile birleştirme: " + string.Concat(metin, metin2));
//Console.WriteLine("Metin 1 için karakter sayısı: " + metin.Length );
//Console.WriteLine("İndexOf örneği: " + metin.IndexOf("is"));
//Console.WriteLine("Startswith örneği: " + metin.StartsWith("merhaba"));
//Console.WriteLine(metin.Trim());
//Console.WriteLine(metin.ToUpper());
//Console.WriteLine(metin.ToLower());
//Console.WriteLine("Remove metodu: " + metin.Remove(4));
//Console.WriteLine("Replace fonksiyonu: " + metin.Replace("a", "A"));
//Console.WriteLine("Substring fonksiyonu: " + metin.Substring(4));

//Console.Read();



//Console.WriteLine("Gün:" + DateTime.Now.Day);
//Console.WriteLine("Ay:" + DateTime.Now.Month);
//Console.WriteLine("Yıl:" + DateTime.Now.Year);
//Console.WriteLine("Saat:" + DateTime.Now.Hour);
//Console.WriteLine("Dakika:" + DateTime.Now.Minute);
//Console.WriteLine("Saniye:" + DateTime.Now.Second);
//Console.WriteLine("Kısa tarih bilgisi:" + DateTime.Now.ToShortTimeString());
//Console.WriteLine("Uzun tarih bilgisi:" + DateTime.Now.ToLongDateString());


//TimeSpan zaman;
//int gunFarki;
//DateTime tarih1, tarih2;
//tarih1 = Convert.ToDateTime("01.01.2020"); 
//tarih2 = Convert.ToDateTime("15.01.2020");
//zaman = tarih2 - tarih1;
//gunFarki = zaman.Days;
//Console.WriteLine("Fark:" + gunFarki);
//Console.Read();

//int sayi;
//Random random = new Random();
//sayi = random.Next(0, 51);
//Console.WriteLine(sayi);
//Console.Read();


//Random random = new Random();
//int sehir;
//string[] sehirler = { "Adana", "Ankara", "Bursa", "İstanbul" };
//sehir = random.Next(0, sehirler.Length);
//Console.WriteLine(sehirler[sehir]);
//Console.Read();

int d1, d2, d3, d4;
Random rand = new Random();
d1 = rand.Next(0, 10);
d2 = rand.Next(0, 10);
d3 = rand.Next(0, 10);
d4 = rand.Next(0, 10);
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
string[] karakterler = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E" };
Console.WriteLine(d1 + karakterler[d2] + d3 + karakterler[d4]);
Console.Read();