//Задача 34  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int a = 0; a < numbers.Length; a++)
// if (numbers[a] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }



//Задача 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.





//Задача 38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  Console.Write("Введите размер массива: ");
    
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[n];
    
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++) {
//           array[i] = new Random().Next(100);
//     }
    
//     Console.Write("myarray: ");
//     for (int i = 0; i < array.Length; i++) {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine(" ");
    
//     int imin = 0, imax = 0;
    
//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] > array[imax])
//             imax = i;
//         if (array[i] < array[imin])
//             imin = i;
//     }
//     Console.WriteLine("min : array[" + imin + "] = " + array[imin]);
//     Console.WriteLine("max : array[" + imax + "] = " + array[imax]);
    

    
//    Console.WriteLine(array[imax]- array[imin]);
  

  

  