using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHomeVorkEvents
{
    public delegate void NotifyWarmUpComplited(string nameFood);
    internal class Microwave
    {
        public event NotifyWarmUpComplited OnWarmUpComplited;  

        public void WarmUp(string nameFood)
        { 
            Console.WriteLine($"Подогреваю {nameFood}");
            if (OnWarmUpComplited != null) {OnWarmUpComplited(nameFood); }
        }
    }
}
