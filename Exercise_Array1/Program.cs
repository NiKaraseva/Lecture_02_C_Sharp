int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {11, 21, 311, 41, 15, 61, 17, 18, 19}; // Определяем массив (вместо перечисления чисел)
//             0   1   2   3   4   5   6   7   8

/*array[0] = 12; // Обратиться к конкретному элементу из массива (и можно поменять его значение) - в [] скобках индекс элемента
Console.WriteLine(array[4]); // Обратиться к массику и получить значение по указанному индексу*/

// Обращаемся к массиву через его индекс
int max = Max(Max(array[0], array[1], array[2]), // max - переменная, Max - функция 
              Max(array[3], array[4], array[5]), 
              Max(array[6], array[7], array[8]));

Console.WriteLine(max);