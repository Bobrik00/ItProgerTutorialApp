using System;
using System.Collections.Generic;

namespace ItProgerTutorialApp
{
    class Program
    {
        public static double sum(double a, double b) 
        {
            return a+b; 
        } 
        public static double sub(double a, double b) 
        {
            return a-b; 
        }
        public static double mul(double a, double b) 
        {
            return a*b; 
        }
        public static double div(double a, double b) 
        {
            return a/b; 
        }        
        public static double root(double a) 
        {
            return Math.Sqrt(a) ; 
        }        
        public static double factor(double a, double b) 
        {
            return Math.Pow(a, b);
        }



        static void Main()
        {

            //-------------   К А К У Л Я Т О Р -------------

            //Переменные
            int a, b, res;
            string input;
            bool ValidInput = false;
            input = "Err";
            char[] symbols = new char[6] { '+', '-', '*', '/', '^', '&' };
            char CurrentSymbol;

            Console.WriteLine("Введите операцию: ");
            input = Console.ReadLine();

            ValidInput = input.All(c => char.IsDigit(c) || char.IsSymbol(c));

            if (!ValidInput)
                Console.WriteLine("Неверный ввод. Пожалуйста, вводите только цифры и следующие символы + - * / ^ &");
            
            
            
            foreach (char character in input)
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    if (symbols[i] == character)
                    {
                        CurrentSymbol = symbols[i];
                    }
                }
                                
                switch(character)
                {
                case '-':
                        sum(a,b)
                        break;
                case '+':

                        break;
                case '*':

                        break;
                case '/':

                        break;
                case '^':

                        break;
                case '&':

                        break;
                }
            }









            //Таски SWITCH CASE

            //-------------------SECOND TASK

            //Console.WriteLine("Введите \"юг\", \"Север\", \"Запад\" или \"Восток\" ");
            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "юг":
            //        Console.WriteLine("На юг пойдёшь, пизды  огребёшь");
            //        break;
            //    case "север":
            //        Console.WriteLine("На север пойдёшь, пизды  огребёшь");
            //        break;
            //    case "запад":
            //        Console.WriteLine("На запад пойдёшь, пизды  огребёшь");
            //        break;
            //    case "восток":
            //        Console.WriteLine("На восток пойдёшь, пизды  огребёшь");
            //        break;
            //    default:
            //        Console.WriteLine("Ты чё пёс, я тебе хату разнесу");
            //        break;

            //}

            //-------------------FIRST TASK

            //byte input = Convert.ToByte(Console.ReadLine());
            //string[] week = new string[7]
            //{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};

            //switch (input)
            //{
            //    case 1:
            //        Console.WriteLine(week[input - 1]);
            //        break;
            //    case 2:
            //        Console.WriteLine(week[input - 1]);
            //        break;
            //    case 3:
            //        Console.WriteLine(week[input - 1]);
            //        break;
            //    case 4:
            //        Console.WriteLine(week[input - 1]);
            //        break;
            //    case 5:
            //        Console.WriteLine(week[input - 1]);
            //        break;
            //    case 6:
            //        Console.WriteLine(week[input - 1]);
            //        break;
            //    case 7:
            //        Console.WriteLine(week[input - 1]);
            //        break;
            //}



            // Таски FOREACH и динамические массивы. Тасок было 5 но я усложнил себе задачу и всё сделал



            //--------------- THIRD TASK

            //List<int> numbers = new List<int>();
            //byte a = 0;
            //int sum = 0;
            //do
            //{
            //    numbers.Add(a + 1);
            //    a++;
            //    Console.WriteLine($"Добавлено {a} в переменную {numbers.Count} массива numbers");
            //}
            //while (numbers.Count < 10);

            //foreach (int i in numbers) 
            //{
            //    sum += i;
            //}

            //Console.WriteLine($"Сумма всех чисел в массиве: {sum}");
            //Console.WriteLine($"Длина массива: {numbers.Count}");
            //------------ SECOND TASK

            //List<string> fruits = new List<string>();
            //string slog;
            //byte NumOfletters = 0;

            //slog = Convert.ToString(Console.ReadLine());

            //NumOfletters = Convert.ToByte(slog.Length);


            //fruits.Add("Апельсин");
            //fruits.Add("Банан");
            //fruits.Add("Яблоко");
            //fruits.Add("Хуйбезсоли");
            //fruits.Add("Ананас");
            //fruits.Add("Апанасий");

            //foreach (string fruit in fruits)
            //{
            //    if (fruit[..slog.Length] == slog)
            //    {
            //        Console.WriteLine(fruit);
            //    }
            //}



            //------------------FIRST TASK 
            //int[] numbers = { 1, 2, 3, 4, 5, };
            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}




            // Таски IF ELSE


            //-------------- FIFTH TASK ---------- Всё сделал сам, но нейросеть помогла оптимизировать IFы и добавить try catch

            //byte month;
            //Console.WriteLine("Введите месяц (от 1 до 12): ");
            //try
            //{
            //    month = Convert.ToByte(Console.ReadLine());
            //    if (month < 1 || month > 12)
            //    {
            //        Console.WriteLine("Ошибка: введите число от 1 до 12.");
            //    }
            //    else if (month < 4)
            //    {
            //        Console.WriteLine($"{month} это 1 квартал");
            //    }
            //    else if (month < 7)
            //    {
            //        Console.WriteLine($"{month} это 2 квартал");
            //    }
            //    else if (month < 10)
            //    {
            //        Console.WriteLine($"{month} это 3 квартал");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{month} это 4 квартал");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //------------------------- FOURTH TASK - Сделал с подсказкой нейросети

            //int a, b, c, temp;
            //Console.WriteLine("Введите 3 числа :");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());

            //if (a>b)
            //{
            //    temp = a;
            //    a = b;
            //    b = temp;

            //}

            //if (a > c)
            //{
            //    temp = a;
            //    a = c;
            //    c = temp;
            //}
            //else
            //if (b > c)

            //{
            //    temp = b;
            //    b = c;
            //    c = temp;
            //}
            //else

            //Console.WriteLine($"{a}, {b}, {c}");


            //----------------------THIRD TASK - я не осилил саму логику в операторе IF.

            //Console.Write("Введите год: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //    Console.WriteLine("Год " + year + " является високосным.");
            //else
            //    Console.WriteLine("Год " + year + " не является високосным.");


            //if (year % 4 == 0 ^ (year % 100 == 0 && year % 400 == 0))
            //    Console.WriteLine($"год {year} вЫсокосный");
            //else Console.WriteLine($"год {year} не вЫсокосный");


            //-------------------SECOND TASK


            //int a, b, c;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = a > b ? (a) : (b);
            //Console.WriteLine(c);


            //------------ FIRST TASK
            //int chetnoe;
            //chetnoe = Convert.ToInt32(Console.ReadLine());
            //if (chetnoe % 2 == 0)
            //{
            //    Console.WriteLine($"Число {chetnoe} чётное");
            //}
            //else {Console.WriteLine($"Число {chetnoe} не чётное"); }


            //Ниже таски с массивами


            //-------------- FIFTH TASK

            //int[] FT_1 = new int[7];
            //int[] FT_2 = new int[5];
            ////int i = 0;
            //Random rnd = new();


            //for (int i = 0; i < FT_1.Length; i++)
            //{
            //    FT_1[i] = rnd.Next(0,100);
            //    Console.WriteLine("Первый массив: " + FT_1[i]);
            //}

            //Array.Copy(FT_1,2, FT_2, 0, 5);
            //for (i = 0; i < FT_2.Length; i++)
            //{
            //    Console.WriteLine("Второй массив: " + FT_2[i]);
            //}


            //--------------------------- FOURTH TASK

            //int[] FourthTask = new int[] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < FourthTask.Length; i++)
            //{
            //    Console.WriteLine($"Переменная массива {i} равна {FourthTask[i]}");
            //}
            //    Array.Clear( FourthTask );


            //Console.WriteLine("После очистки ------------ ");
            //for (int i = 0; i < FourthTask.Length; i++)
            //{

            //    Console.WriteLine($"Переменная массива {i} равна {FourthTask[i]}");
            //}

            //Console.WriteLine(FourthTask.Length);

            //-------------- THIRD TASK

            //int min = int.MaxValue;
            //int max = int.MinValue;
            //Random rnd = new Random();
            //int[,] ThirdTask = new int[5, 5];

            //for (int F = 0; F < ThirdTask.GetLength(0); F++)
            //{
            //    for (int S = 0; S < ThirdTask.GetLength(1); S++)
            //    {
            //        ThirdTask[F, S] = rnd.Next(1, 100);
            //        Console.WriteLine($"В массиве {F + 1} Значение {S} равняется: {ThirdTask[F, S]}");

            //        min = Math.Min(min, ThirdTask[F, S]); //тут всё верно
            //        max = Math.Max(max, ThirdTask[F, S]); //тут всё верно

            //    }
            //}

            //Console.WriteLine($"min: {min}");
            //Console.WriteLine($"max: {max}");






            //------------------------SECOND TASK

            //int[] SecondTask = new int[rnd.Next(0,20)];

            //for (int i = 0; i < SecondTask.Length; i++)
            //{
            //    SecondTask[i] = rnd.Next(0,100);
            //    if (SecondTask[i] % 2 == 0)
            //    {
            //        Console.WriteLine("Попытка {1} и Значение {0} чётное", SecondTask[i], i+1);
            //    }

            //    else Console.WriteLine("Попытка {1} и Значение {0} не чётное", SecondTask[i], i+1);

            //}


        }
    }
}