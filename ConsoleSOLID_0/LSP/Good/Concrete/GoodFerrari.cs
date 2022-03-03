using ConsoleSOLID_0.LSP.Good.Abstract;
using ConsoleSOLID_0.LSP.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.LSP.Good.Concrete
{
    public class GoodFerrari : GoodAraba , IKlima
    {
        public string KlimaCalistir()
        {
            return "Ferrari kliması";
        }
    }
}
