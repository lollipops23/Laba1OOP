//Вариант 13 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;



namespace _01_oop
{
    public struct Animals
    {
        public string _animal;
        public string _class;
        public Animals(string animal, string classAn)
        {
            _animal = animal;
            _class = classAn;
        }
        public string GetFullAnimals()
        {
            return $"Животное: {_animal}; Класс: {_class}";
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания: ");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Clear();
                        Console.WriteLine($"Выполняю задание №{num}");
                        int[] A;
                        A = new int[15];

                        Console.WriteLine("Введите 15 элементов массива");
                        for (var i = 0; i < A.Length; i++)
                        {
                            Console.Write($"A[{i}] = ");
                            A[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int sum = A.Where(i => i % 2 == 0).Sum();
                        Console.WriteLine($"Cумма четных чисел: {sum}");
                        break;

                    case 2:
                        Clear();
                        Console.WriteLine($"Выполняю задание №{num}");
                        decimal[,] A1 = new decimal[3, 5];
                        decimal[,] A2 = new decimal[3, 5];

                        Random random = new Random();

                        for (var i = 0; i < A1.GetLength(0); i++)
                        {
                            for (var j = 0; j < A1.GetLength(1); j++)
                            {
                                A1[i, j] = Math.Round((random.Next(1050, 3000) / 3.0m), 0);
                            }
                        }
                        Console.WriteLine("1 матрица");
                        for (var i = 0; i < A1.GetLength(0); i++)
                        {
                            for (var j = 0; j < A1.GetLength(1); j++)
                            {
                                Console.Write(A1[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        for (var i = 0; i < A2.GetLength(0); i++)
                        {
                            for (var j = 0; j < A2.GetLength(1); j++)
                            {
                                A2[i, j] = Math.Round((random.Next(1050, 3000) / 3.0m), 0);
                            }
                        }
                        Console.WriteLine("\n2 матрица");
                        for (var i = 0; i < A2.GetLength(0); i++)
                        {
                            for (var j = 0; j < A2.GetLength(1); j++)
                            {
                                Console.Write(A2[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\nИтоговая матрица");
                        int[,] C = new int[3, 5];
                        for (var i = 0; i < A1.GetLength(0); i++)
                        {
                            for (var j = 0; j < A1.GetLength(1); j++)
                            {
                                C[i, j] = Math.Max(Convert.ToInt32(A1[i, j]), Convert.ToInt32(A2[i, j]));
                            }
                        }
                        for (var i = 0; i < C.GetLength(0); i++)
                        {
                            for (var j = 0; j < C.GetLength(1); j++)
                            {
                                Console.Write(C[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Clear();
                        Console.WriteLine($"Выполняю задание №{num}");
                        List<Animals> animal = new List<Animals>();
                        var animal1 = new Animals("Собака", "Млекопитающее");
                        animal.Add(animal1);
                        var animal2 = new Animals("Кошка", "Млекопитающее");
                        animal.Add(animal2);
                        var animal3 = new Animals("Жаба", "Земноводные");
                        animal.Add(animal3);
                        var animal4 = new Animals("Тритон", "Земноводное");
                        animal.Add(animal4);
                        var animal5 = new Animals("Капибара", "Млекопитающее");
                        animal.Add(animal5);
                        Console.WriteLine("--------------Животные--------------");
                        animal.ForEach(s => Console.WriteLine(s.GetFullAnimals()));
                        Console.WriteLine("--------Только млекопитающие--------");
                        foreach (var i in animal)
                        {
                            if (i._class == "Млекопитающее")
                            {
                                Console.WriteLine(i.GetFullAnimals());
                            }
                        }
                        Console.ReadLine();

                        break;
                    default:
                        Clear();
                        Console.WriteLine("Недопустимые данные");
                        break;
                }



            }
        }
    }
}