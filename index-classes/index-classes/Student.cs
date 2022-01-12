using System;
using System.Collections.Generic;
using System.Text;

namespace index_classes
{
    class Student
    {
        public static int counter;
        public Student() { counter++; }
        public string Surname { get; set; }

        public string Name { get; set; }

        public string MidleName { get; set; }

        public uint Course { get; set; }

        public string Faculty { get; set; }

        public uint GradeBook { get; set; }
    }
    class People
    {
        public Student[] data;
        public People()
        {
            Console.WriteLine("Добро пожадовать,");
            Console.WriteLine("Ввeдите количество студентов: ");
            uint x = CheckNumber();
            data = new Student[x];
        }
        public uint CheckNumber()
        {          
            do
            {
                if (UInt32.TryParse(Console.ReadLine(), out uint n))
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
            }
            while (true);
        }

        public Student this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public string CheckString()
        {
            string name;
            uint countofInvalid = 0;
            string symbolInvalid = "1234567890/} {)(|@%$&*!?,.`~=-#";
            string enter = "";  
            do
            {
                countofInvalid = 0;
                name = Console.ReadLine();
                if (name == enter)
                {
                    countofInvalid++;
                }
                foreach (char numb1 in name)
                {
                    foreach (char numb2 in symbolInvalid)
                        if (numb1 == numb2)
                        {
                            countofInvalid++;
                        }
                }
                if (countofInvalid > 0)
                {
                    Console.WriteLine("Имя введенно не корректно,ведите имя повторно");
                }
            }
            while (countofInvalid > 0);
            return name;
        }
        public Student[] ReadArray()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Введите даннык {i+1} студента");
                data[i] = new Student();
                Console.Write($"Введите фамилиюстудента:  ");
                data[i].Surname = CheckString();
                Console.Write($"Введите имя: ");
                data[i].Name = CheckString();
                Console.Write($"Введите отчество: ");
                data[i].MidleName = CheckString();
                Console.Write($"Введите номер курса: ");
                data[i].Course = CheckNumber();
                Console.Write($"Введите факультет: ");
                data[i].Faculty = CheckString();
                Console.Write($"Введите номер зачетной книги: ");
                data[i].GradeBook = CheckNumber();              
            }
            return data;
        }
        public void Print()
        {
            if (data.Length!=0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine($"Данные {i + 1} студента");
                    Console.WriteLine($"Фамилия = {data[i].Surname} Имя = {data[i].Name} Отчество = {data[i].MidleName} Курс обучения = {data[i].Course} Факультет = {data[i].Faculty} Номер зачетной книги = {data[i].GradeBook}");
                }
            }
            else
            {
                Console.WriteLine("\nСписок студентов пуст.\n");
            }
            
        }
        public void PrintIndex()
        {
            Console.WriteLine("Введите индекс ");
            uint i = CheckNumber();
            Console.WriteLine($"Фамилия = {data[i - 1].Surname} Имя  = {data[i - 1].Name} Отчество = {data[i - 1].MidleName} Course = {data[i - 1].Course} Faculty = {data[i - 1].Faculty} GradeBook = {data[i - 1].GradeBook}");
        }

        public Student[] Insert()
        {
            Array.Resize(ref data, data.Length + 1);
            for (int i = data.Length-1; i < data.Length; i++)
            {
                Console.WriteLine($"Введите даннык {i + 1} студента");
                data[i] = new Student();
                Console.Write($"Введите фамилиюстудента:  ");
                data[i].Surname = CheckString();
                Console.Write($"Введите имя: ");
                data[i].Name = CheckString();
                Console.Write($"Введите отчество: ");
                data[i].MidleName = CheckString();
                Console.Write($"Введите номер курса: ");
                data[i].Course = CheckNumber();
                Console.Write($"Введите факультет: ");
                data[i].Faculty = CheckString();
                Console.Write($"Введите номер зачетной книги: ");
                data[i].GradeBook = CheckNumber();
            }
            return data;
        }
        public void RemoveAt(ref Student[] data)
        {
            Console.WriteLine("Введите индекс студента: ");
            uint index = CheckNumber()-1;
            Student[] mydata = new Student[data.Length - 1];
            for (uint i = 0; i < index; i++)
            {
                mydata[i] = data[i];
            }
            for (uint i = index + 1; i < data.Length; i++)
            {
                mydata[i - 1]  = data[i];
            }
            data = mydata;
            Student.counter--;
        }
    }
}
