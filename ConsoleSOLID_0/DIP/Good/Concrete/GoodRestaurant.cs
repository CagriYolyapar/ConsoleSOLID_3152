using ConsoleSOLID_0.DIP.Good.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.Good.Concrete
{
    public class GoodRestaurant
    {
        //Bu versiyonda Restaurant sınıfı alt seviye modüllerden bagımsız bir hale gelecektir...Kendisine ne geliyorsa ona göre bir işlem gerçekleştireceğiz...IProduct tipine gevşek bir şekilde baglıyız(loosely coupled)

        List<IProduct> _products;


        //Dependency Inversion prensibiniz Dependency Injection tasarım paterniniz ile gerçekleştirilir... Bu design pattern sizin Injection dediginiz yöntemi bir Interface veya class sayesinde ilgili yapınıza entegre etmenizle olur...
        public GoodRestaurant(List<IProduct> products)
        {

            //Tightly Coupled(sıkı sıkıya bagımlı olan) bir yapıyı burada loosely coupled(gevsek bir şekilde baglı olan) yapıya cevirmek icin Dependency Injection tasarım paternini(constructor based injection) kullandık
            _products = products;
        }

        public string GenerateInstructions()
        {
            string insructions = null;

            foreach (IProduct item in _products)
            {
                insructions += item.GetCookingInstructions();
            }

            return insructions;
        }
    }
}
