using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            int EkzCount = 0;
            double temp;
            string MasOut;
            int CountOut = 1;
            Console.WriteLine("Введите количество экземпляров показаний с датчиков погоды");
            EkzCount = Convert.ToInt32(Console.ReadLine());
            Indications[] Weather = new Indications[EkzCount];

            for(int i = 0; i<EkzCount; i++)//заполнение элементов массива
            {
                Console.WriteLine("Введите значение температуры для " + i + "-го экземпляра");
                Weather[i] =  new Indications();
                Weather[i].temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение влажности для " + i + "-го экземпляра");
                Weather[i].wet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение давления для " + i + "-го экземпляра");
                Weather[i].pressure = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Для вывода массива нажмите Y, иначе - закрытие программы");
            MasOut = Console.ReadLine().ToUpper();

            if (MasOut == "Y")
                foreach(var s in Weather)//Вывод массива
                {
                    Console.WriteLine("Экземпляр №" + CountOut +" Температура: " + s.temperature + " Влажность: " + s.wet + " Давление: " + s.pressure);
                    CountOut++;
                }
            FileOut(Weather);

                Console.ReadKey();
        }

        public static void FileOut(Indications[] Weather)
        {
            int CountOutFile = 1;
            using (StreamWriter Write = new StreamWriter("Weater.txt"))
            {
                foreach (var s in Weather)
                {
                    Write.WriteLine("Экземпляр №" + CountOutFile + " Температура: " + s.temperature + " Влажность: " + s.wet + " Давление: " + s.pressure);
                    CountOutFile++;
                }

            }
        }
    }

        //public void Read()

        //{

        //    file = File.ReadAllLines(Way, System.Text.Encoding.Default);

        //    for (int i = 0; i < file.Length; i++)

        //    {

        //        Console.WriteLine(file[i]);

        //    }

        //}

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
