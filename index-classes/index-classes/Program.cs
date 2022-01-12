using System;

namespace index_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
             people.ReadArray();
                bool finish = true;
            do
            {
                Console.WriteLine("выберите действия");
                Console.WriteLine("1 Добавить студента");
                Console.WriteLine("2 Удаление студента ");
                Console.WriteLine("3 Количество студентов");
                Console.WriteLine("4 Cписок всех студентов");
                Console.WriteLine("5 Даннык студента по порядковому индексу");
                Console.WriteLine("6 Выход из приложения");

                Console.WriteLine("Выберите одно из выше указанных действий: ");
                uint number = people.CheckNumber();
                try
                {
                    switch (number)
                    {
                        case 1:
                            people.Insert();
                            break;
                        case 2:
                            people.RemoveAt(ref people.data);

                            break;
                        case 3:
                            Console.WriteLine($"\nКоличество студентов {Student.counter}\n");
                            break;
                        case 4:
                            people.Print();
                            break;
                        case 5:
                            people.PrintIndex();
                            break;
                        case 6:
                            Console.WriteLine("Выход из приложения");
                            finish = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!!!Введите верные данные");
                }
            }
            while (finish == true);
            Console.ReadKey();

        }
    }
}
