using ConsoleSOLID_0.DIP.Good.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.Good.Concrete
{
    public class GoodMeat : IProduct
    {
        public string GetCookingInstructions()
        {
            return "Kırmızı et";
        }
    }
}
