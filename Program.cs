// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// тип возвращающнго значения + Название + ()+ {}

System.Console.WriteLine("Введите число");
int sizeArray= Convert.ToInt32(Console.ReadLine());

int [] array = new int[sizeArray];

void GetArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }  
}

int GetCountElement()
{
    int countEl=0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%7==0 && array[i]%10==1)   //     && - и     || - или
        {
            countEl++;
        }
    }
    return countEl;
}

GetArray();
PrintArray();
int newNum = GetCountElement();

System.Console.WriteLine("Кол. = " +newNum);
