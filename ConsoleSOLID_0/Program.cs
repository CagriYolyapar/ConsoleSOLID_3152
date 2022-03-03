using ConsoleSOLID_0.DIP.Good.Concrete;
using ConsoleSOLID_0.DIP.Good.Interface;
using ConsoleSOLID_0.LSP.BAD;
using ConsoleSOLID_0.LSP.Good.Concrete;
using ConsoleSOLID_0.LSP.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0
{
    class Program
    {
        /*
             S => Single Responsibility => Bir yapının tekil bir sorumluluga sahip olmasıdır(DantexCrypt, MailService class'ımızın hepsinin görevi tektir...) Baska bir sorumluluk almamıslardır. N-Tier paterninin katmanlarına bakabilirsiniz...Kullandıgımız metotlar hep tekil sorumluluktadır...

            O => Open Closed => Bir projenin gelişmeye açık değişime kapalı olmasıdır..Değişimden kastımız projenin normalde hicbir hata cıkarmayan ve güzel bir şekilde calısan kaynak kodlarının kökten modifiye edilmesidir. BU sekilde proje degişiyorsa proje Open Closed prensibine aykırıdır...Proje eger gercekten gelişecek ise güzel bir şekilde calısan kodlar bozulmadan üzerine zarif eklemeler yaparak gelişmesi gerekir...

            L => Liskov's Substitution => Bir yapılar kümesinin tek bir catı altında toplanması halinde bu catı icerisinde bulunan her nesnenin Base'teki tipinden kullanıldıgı zaman Base'deki her türlü davranısa sadık kalmasıdır...Yani BaseClass tipimizde bir koleksiyon yaratıyorsak ve bu koleksiyon icerisine farklı nesneler alıyorsak BaseClass tipinin her davranısı bu nesnelerin herbiri icin anlamlı eylemler olmak zorundadır...


            I => Interface Segregation => Yarattıgımız Interface'ler icerisinde implement edilmeyecek veya kullanılmayacak metotların yazılmaması gerektigini savunan bir prensiptir...Cünkü böyle yapmak Interface'in gereksiz kodlarla bogulmasına neden olacaktır...

            D => Dependency Inversion => Yüksek seviyeli bir modülün/yapının/class'ın alt seviyedeki bir modüle tightly coupled bir şekilde baglanmaması gerektigini savunan bir prensiptir... Bu prensibe göre Interface destegi ile modülü loosely coupled bir hale getirmiş oluruz...Böylece bu modül başka yerlere gittiginde de rahatca adapte olabilecektir... 




        
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         */







        static void Main(string[] args)
        {

            #region BadPractice
            //List<Araba> arabalar = new List<Araba>
            //{
            //    new Tofas(), new Ferrari()
            //};


            //foreach (Araba item in arabalar)
            //{

            //    if (item is Ferrari)
            //    {
            //        Console.WriteLine(item.KlimaCalistir());
            //    }


            //}

            //Console.ReadLine(); 
            #endregion

            #region GoodLSP
            //List<IKlima> klimaliArabalar = new List<IKlima>
            //{
            //    new GoodFerrari(),new GoodLamborghini()
            //};

            //foreach (IKlima item in klimaliArabalar)
            //{
            //    Console.WriteLine(item.KlimaCalistir());
            //}

            //Console.ReadLine(); 
            #endregion

            #region GoodDI
            List<IProduct> urunler = new List<IProduct>
            {
                new GoodChicken(),new GoodFish(), new GoodMeat()
            };


            GoodRestaurant gr = new GoodRestaurant(urunler);
            Console.WriteLine(gr.GenerateInstructions());
            Console.ReadLine(); 
            #endregion

        }
    }
}
