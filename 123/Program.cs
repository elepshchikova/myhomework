//Задача 34
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

//Задача 36
// int[] a = new int[4];
// for (int i = 0; i < a.Length; i++)
// {
//     Console.Write($"Введите a[{i}] = ");
//     a[i] = int.Parse(Console.ReadLine());
// }
// int sum = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] % 2 == 1)
//         sum += a[i];
// }
// Console.WriteLine($"Сумма нечетных чисел = {sum}");

//Задача 38
 Console.Write("Введите размер массива: ");
    
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) {
          array[i] = new Random().Next(100);
    }
    
    Console.Write("myarray: ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    
    int imin = 0, imax = 0;
    
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > array[imax])
            imax = i;
        if (array[i] < array[imin])
            imin = i;
    }
    Console.WriteLine("min : array[" + imin + "] = " + array[imin]);
    Console.WriteLine("max : array[" + imax + "] = " + array[imax]);
    

    
   Console.WriteLine(array[imax]- array[imin]);
  

