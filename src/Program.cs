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
            int EkzCount = 0;
            double temp;
            string MasOut;
            int CountOut;
            Console.WriteLine("Введите количество экземпляров показаний с датчиков погоды");
            EkzCount = Convert.ToInt32(Console.ReadLine());
            Indications[] IndMas = new Indications[EkzCount];
            for(int i = 0; i<EkzCount; i++)//заполнение элементов массива

            {
                Console.WriteLine("Введите значение температуры для " + i + "-го экземпляра");
                IndMas[i] =  new Indications();
                IndMas[i].temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение влажности для " + i + "-го экземпляра");
                IndMas[i].wet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение давления для " + i + "-го экземпляра");
                IndMas[i].pressure = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Для вывода массива нажмите Y");
            MasOut = Console.ReadLine().ToUpper();
            if (MasOut == "Y")
                foreach(var s in IndMas)//Вывод массива
                {
                    Console.WriteLine("Температура: " + s.temperature + " Влажность: " + s.wet + " Давление: " + s.pressure);

                }
                Console.ReadKey();
        }
    }

    class Indications
    {
        public double temperature;
        public int wet;
        public int pressure;

        public Indications(double Temperature, int Wet, int Pressure)
        {
            temperature = Temperature;
            wet = Wet;
            pressure = Pressure;

        }
        public Indications()
        {


        }

    }
}
