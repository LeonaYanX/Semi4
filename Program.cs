// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// тип возвращающнго значения + Название + ()+ {}

// System.Console.WriteLine("Введите число");
// int sizeArray= Convert.ToInt32(Console.ReadLine());

// int [] array = new int[sizeArray];

// void GetArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,100);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }  
// }

// int GetCountElement()
// {
//     int countEl=0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%7==0 && array[i]%10==1)   //     && - и     || - или
//         {
//             countEl++;
//         }
//     }
//     return countEl;
// }

// GetArray();
// PrintArray();
// int newNum = GetCountElement();

// System.Console.WriteLine("Кол. = " +newNum);

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


// System.Console.WriteLine("Введите число");
// int sizeArray= Convert.ToInt32(Console.ReadLine());

// int [] array = new int[sizeArray];

// void GetArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }  
// }

// string GetNumber()
// {
//     string result="";

//     for (int i = 0; i < array.Length; i++)
//     {
//         result = result + array[i];
//     }
//     return result;
// }

// GetArray();
// PrintArray();
// string newNum= GetNumber();

// System.Console.WriteLine("Число = " +newNum);
