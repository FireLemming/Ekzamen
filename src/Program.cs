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
            int wet = 0;
            double temp = 0;
            int pressure = 0;
            string MasOut;
            int CountOut = 1;
            bool errflagwet = false;
            bool errflagpressure = false;
            bool errflagtemp = false;
            Console.WriteLine("Введите количество экземпляров показаний с датчиков погоды");
            try
            {
                EkzCount = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите корректное значение больше 0");
            }
            Indications[] Weather = new Indications[EkzCount];

            for(int i = 0; i<EkzCount; i++)//заполнение элементов массива
            {
                Weather[i] =  new Indications();



                do
                {
                    errflagtemp = false;
                    Console.WriteLine("Введите значение температуры для " + i + "-го экземпляра");
                    try
                    {
                        temp = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите верное знаечение ");
                        errflagtemp = true;
                    }
                    if (temp > 150 || wet <= -150)
                        Console.WriteLine("Введите значение влажности от 1 до 100%");
                }
                while (temp > 150 || wet <= -150 || errflagtemp == true); // && wet.ToString().AsEnumerable().Any(s => char.IsLetter(s))
                Weather[i].temperature = temp;

                do
                {
                    errflagwet = false;
                    Console.WriteLine("Введите значение влажности для " + i + "-го экземпляра");
                    try
                    {
                        wet = Convert.ToInt32(Console.ReadLine());
                    }
                    catch { Console.WriteLine("Введите верное знаечение ");
                        errflagwet = true;
                    }
                    if(wet>100 || wet <=0)
                        Console.WriteLine("Введите значение влажности от 1 до 100%");
                } 
                while (wet > 100 || wet <= 0 || errflagwet == true); // && wet.ToString().AsEnumerable().Any(s => char.IsLetter(s))
                Weather[i].wet = wet;

                do
                {
                    errflagpressure = false;
                    Console.WriteLine("Введите значение давления для " + i + "-го экземпляра");
                    try
                    {
                        pressure = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите верное знаечение ");
                        errflagpressure = true;
                    }
                    if (pressure <= 0 || pressure > 1000)
                        Console.WriteLine("Введите значение влажности от 1 до 1000");


                } while (pressure <= 0 || pressure >1000|| errflagpressure == true) ;
                
                Weather[i].pressure = pressure;
            }

            Console.WriteLine("Для вывода массива нажмите Y, иначе - закрытие программы");
            MasOut = Console.ReadLine().ToUpper();


            if (MasOut == "Y" || MasOut == "Н")
                foreach(var s in Weather)//Вывод массива
                {
                    Console.WriteLine("Экземпляр №" + CountOut +" Температура: " + s.temperature + " Влажность: " + s.wet + "% Давление: " + s.pressure);
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
