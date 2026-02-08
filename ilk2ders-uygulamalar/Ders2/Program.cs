// See https://aka.ms/new-console-template for more information

#region Double Değişkenler

//double number = 4.85;

//Console.WriteLine(number);

//Meyve-Sebze Ekranı

//Console.WriteLine("-------- Fiyat Listesi -----------");
//Console.WriteLine();

//double applePrice, orangePrice, strawberryPrice,
//    potatoPrice, tomatoPrice;

//applePrice = 14.85;
//orangePrice = 20.95;
//strawberryPrice = 45;
//potatoPrice = 9.74;
//tomatoPrice = 6.88;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("----Elma Birim Fiyatı    : " + applePrice      + "₺");
//Console.WriteLine("----Portakal Birim Fiyatı: " + potatoPrice     + "₺");
//Console.WriteLine("----Çilek Birim Fiyatı   : " + strawberryPrice + "₺");
//Console.WriteLine("----Patates Birim Fiyatı : " + potatoPrice     + "₺");
//Console.WriteLine("----Domates Birim Fiyatı : " + tomatoPrice     + "₺");
//Console.WriteLine("----------------------------------");

//double appleKiloGram, orangeKiloGram, strawberryKiloGram, potatoKiloGram, tomatoKiloGram;

//appleKiloGram = 1.245;
//orangeKiloGram = 2.650;
//strawberryKiloGram = 0.750;
//potatoKiloGram = 4.859;
//tomatoKiloGram = 3.745;

//double appleTotalPrice      = appleKiloGram      * applePrice;
//double orangeTotalPrice     = orangeKiloGram     * orangePrice;
//double strawberryTotalPrice = strawberryKiloGram * strawberryPrice;
//double potatoTotalPrice     = potatoKiloGram     * potatoPrice;
//double tomatoTotalPrice     = tomatoKiloGram     * tomatoPrice;

//Console.WriteLine();
//Console.WriteLine("Alınan Ürün: Elma");
//Console.WriteLine("Birim Fiyat: " + applePrice           +   "₺");
//Console.WriteLine("Miktar     : " + appleKiloGram        + " kg");
//Console.WriteLine($"Tutar     :  {appleTotalPrice:F2}₺"         );

//Console.WriteLine();
//Console.WriteLine("Alınan Ürün: Portakal");
//Console.WriteLine("Birim Fiyat: " + orangePrice          +   "₺");
//Console.WriteLine("Miktar     : " + orangeKiloGram       + " kg");
//Console.WriteLine($"Tutar     :  {orangeTotalPrice:F2}₺"        );

//Console.WriteLine();
//Console.WriteLine("Alınan Ürün: Çilek");
//Console.WriteLine("Birim Fiyat: " + strawberryPrice      +   "₺");
//Console.WriteLine("Miktar     : " + strawberryKiloGram   + " kg");
//Console.WriteLine("Tutar      : " + strawberryTotalPrice +   "₺");

//Console.WriteLine();
//Console.WriteLine("Alınan Ürün: Patates");
//Console.WriteLine("Birim Fiyat: " + potatoPrice          +   "₺");
//Console.WriteLine("Miktar     : " + potatoKiloGram       + " kg");
//Console.WriteLine($"Tutar     :  {potatoTotalPrice:F2}₺"        );

//Console.WriteLine();
//Console.WriteLine("Alınan Ürün: Domates");
//Console.WriteLine("Birim Fiyat: " + tomatoPrice          +   "₺");
//Console.WriteLine("Miktar     : " + tomatoKiloGram       + " kg");
//Console.WriteLine($"Tutar     :  {tomatoTotalPrice:F2}₺"        );

//double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice +
//                            strawberryTotalPrice + potatoTotalPrice + 
//                            tomatoTotalPrice;

//Console.WriteLine($"\nAlışveriş Toplam Tutarı: {shoppingTotalPrice:F2}₺");

#endregion

#region Char Değişkenler

//char symbol = 'a';

//Console.WriteLine(symbol);

#endregion

#region Klavyeden Veri Girişleri String Değişkenler

//Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
//Console.WriteLine();

//string passengerName, passengerSurname, passengerDistrict, passengerCity,
//    passengerAge, passengerIdentityNumber;

//Console.Write("Yolcu Adı: ");
//passengerName = Console.ReadLine();

//Console.Write("Yolcu Soyadı: ");
//passengerSurname = Console.ReadLine();

//Console.Write("İlçe Bilgisi: ");
//passengerDistrict = Console.ReadLine();

//Console.Write("Şehir Bilgisi: ");
//passengerCity = Console.ReadLine();

//Console.Write("Yolcu Yaş: ");
//passengerAge = Console.ReadLine();

//Console.Write("Yolcu TC Kimlik No: ");
//passengerIdentityNumber = Console.ReadLine();

//Console.WriteLine();

//Console.WriteLine("------------------------------");
//Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber);
//Console.WriteLine("Yolcu Adı-Soyadı:   " + passengerName + " " + passengerSurname);
//Console.WriteLine("Yaş:                " + passengerAge);
//Console.WriteLine("Adres Bilgisi:      " + passengerDistrict + "/" + passengerCity); 

#endregion

#region Klavyeden Tam Sayı Girişleri ve Dönüşümler

////ABC12D

//int shoesPrice, computerPrice, chairPrice, tvPrice;
//shoesPrice = 1_000;
//computerPrice = 20_000;
//chairPrice = 5_000;
//tvPrice = 12_000;

//int shoesAmount, computerAmount, chairAmount, tvAmount;

//Console.Write("Aldığınız ayakkabı sayısını giriniz: ");
//string input = Console.ReadLine();
//shoesAmount = int.Parse(input);

//Console.Write("Aldığınız bilgisayar sayısını giriniz: ");
//input = Console.ReadLine();
//computerAmount = int.Parse(input);

//Console.Write("Aldığınız sandalye sayısını giriniz: ");
//input = Console.ReadLine();
//chairAmount = int.Parse(input);

//Console.Write("Aldığınız televizyon sayısını giriniz: ");
//input = Console.ReadLine();
//tvAmount = int.Parse(input);

//int totalPrice = shoesAmount * shoesPrice + computerAmount * computerPrice +
//    chairAmount * chairPrice + tvAmount * tvPrice;

//Console.WriteLine();
//Console.WriteLine("Toplam ödemeniz gereken tutar: {0:N0}", totalPrice);

#endregion

#region Klavyeden Ondalık Sayı Girişleri

//byte exam1, exam2, exam3;
//double result;    

//Console.Write("1. sınav notunu giriniz: ");
//string input = Console.ReadLine();
//exam1 = byte.Parse(input);

//Console.Write("2. sınav notunu giriniz: ");
//input = Console.ReadLine();
//exam2 = byte.Parse(input);

//Console.Write("3. sınav notunu giriniz: ");
//input = Console.ReadLine();
//exam3 = byte.Parse(input);

//result = 0.2 * exam1 + 0.2 * exam2 + 0.6 * exam3;

//Console.WriteLine("\nOrtalamanız: " + result);

#endregion

#region Klavyeden Karakter Girişleri

//Console.Write("Cinsiyetinizi giriniz: ");
//string input = Console.ReadLine();
//char gender = char.Parse(input);

//Console.Write("\nCinsiyetiniz: " +  gender);

#endregion



Console.Read();