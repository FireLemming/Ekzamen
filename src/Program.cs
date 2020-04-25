using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    class Indications
    {
        public Indications()
        {
            temperature = 0;
            wet = 0;
            pressure = 0;

        }
        public double temperature;
        public int wet;
        public int pressure;

        public string DateReturn()
        {
            return  "Темература:" + temperature.ToString() + "\n Влажность:" + wet.ToString() + "\n Давление:" + pressure.ToString();
        }
    }
}
