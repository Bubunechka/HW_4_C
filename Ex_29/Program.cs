// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. Данные вводятся с консоли пользователем

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Method(string[] args);
// {
//     int[] massive = new int[8];
//     int i = Console.ReadLine();
    
//     //int i = 0;
//     //string result = string.Empty;
    
//     for(int i = 0; i<= 8; i++) 
//     {
        
//     }

// }
// Console.Write("Вывод: ");

int[] a = Enumerable.Range(1, 8).Select(x => 17 % x).ToArray(); 
foreach (int i in a)
  Console.WriteLine(i);