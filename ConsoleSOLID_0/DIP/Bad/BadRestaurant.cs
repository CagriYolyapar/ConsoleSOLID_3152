using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.Bad
{
    public class BadRestaurant
    {
        BadFish _tuna;

        BadChicken _tavuk;

        public BadRestaurant()
        {
            _tuna = new BadFish();
            _tavuk = new BadChicken();
        }

        public string TumTarifler()
        {
            return $"{_tuna.GetFishCookingInstructions()} {_tavuk.GetChickenCookingInstructions()}";
        }
    }
}
