using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__DERS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            // Console.WriteLine("merhaba dünya");

            //Console.Write("selam");

            //Console.WriteLine("***** Yemek kategorileri******");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Anayemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            // Console.WriteLine("5- Tatılılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek kategorileri******");



            #endregion

            #region String Değişkenler

            //String Değişkenler
            //Değişken_türü değişken adı;


            //string name;
            // name = "Enes";
            // Console.Write(name);

            //string customername;
            //string customersurname;
            //string customerphone;
            //string customerEmail, district, city;

            //customername = "Ali ";
            //customersurname = "Çınar";
            //customerphone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadiköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customername + " " + customersurname);
            //Console.WriteLine("İletişim: " + customerphone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();


            //customername = "Ayşegül";
            //customersurname = "Kaya";
            //customerphone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customername + " " + customersurname);
            //Console.WriteLine("İletişim: " + customerphone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");


            #endregion



            #region Int Değişkenler
            //int
            //int24
            //Console.WriteLine("number");


            int hamburgerprice = 300;
            int cokeprice = 35;
            int waterprice = 10;
            int friesprice = 50;
            int pizzaprice = 250;
            int lemonedeprice = 30;


            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine("");
            Console.WriteLine("---- Hambuger :" + hamburgerprice+ "TL");
            Console.WriteLine("---- Pizza:" + pizzaprice+ "TL");
            Console.WriteLine("---- Kola:" +cokeprice+ "TL" );
            Console.WriteLine("---- Limonata:" + lemonedeprice+ "TL");
            Console.WriteLine("---- Kızartma Tabağı:" + friesprice+ "TL");
            Console.WriteLine("----- Su:" +waterprice+ "TL" );
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();


            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamgurgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamgurgerPrice = hamburgerCount * hamburgerprice;
            totalCokePrice = cokeCount * cokeprice;
            totalWaterPrice = waterCount * waterprice;
            totalLemonadePrice = lemonadeCount * lemonedeprice;
            totalFriesPrice = friesCount * friesprice;
            totalPizzaPrice = pizzaCount * pizzaprice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");


            #endregion
           
            
            Console.Read();
            // yazdırma komutları

        }
    }
}
