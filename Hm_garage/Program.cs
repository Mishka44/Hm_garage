using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hm_garage.garage;

namespace Hm_garage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Garage garage = new Garage();
            
            string symbol;
            do
            {
                Console.WriteLine("Добро пожаловать в гараж! \t выбирете действие: ");
                Console.WriteLine("1 - добавить автомобиль, 2- удалить автомобиль по номеру, 3-  посмотреть автомобили в гараже");
                symbol = Console.ReadLine();

                switch (symbol)
                {
                   case "1":
                        string Name_mark, Model;
                        Console.WriteLine("Введите марку:");
                        Name_mark = Console.ReadLine();
                        if (Name_mark == "porshe")
                        {
                            Console.WriteLine("Введите название модели");
                            Model = Console.ReadLine();
                            if (Model == "911")
                            {
                                turbo_911 t_991 = new turbo_911();
                                garage.AddAuto(t_991);
                            }
                        }
                        if (Name_mark == "mercedes")
                        {
                            Console.WriteLine("Введите название модели");
                            Model = Console.ReadLine();
                            if (Model == "c 63")
                            {
                                C_63 c_63 = new C_63();
                                garage.AddAuto(c_63);
                            }
                        }
                        if (Name_mark == "bmw")
                        {
                            Console.WriteLine("Введите название модели");
                            Model = Console.ReadLine();
                            if (Model == "m5")
                            {
                                m_5 bmw_m5 = new m_5();
                                garage.AddAuto(bmw_m5);
                            }
                        }

                        break;


                    case "2":
                        Console.WriteLine("Введите номер бокса в гараже:");
                        int choice;
                        int.TryParse(Console.ReadLine(), out choice);
                        garage.erase_auto(choice);
                        Console.WriteLine("Удаление прошло успешно!");
                        break;
                    case "3":
                        foreach (var item in garage.List)
                            {
                            Console.WriteLine($"номер машины: {item.Id}, {item.Name}");
                            
                            }
                            break;


                } 


            } while (symbol != "q");
        }
    }
}
