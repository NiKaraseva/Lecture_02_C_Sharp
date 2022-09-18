void FillArray(int[] collection) // назначаем элементы в массив
// void метод – метод, который ничего не возвращает
// collection – это просто название аргумента
{
    int length = collection.Length; // Задаём длину массива
    int index = 0; 
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Назначение рандомного числа от 1 до 10
        index++;
    }
}

void PrintArray(int[] col) // делаем метод, который напечатает массив
{
    int count = col.Length; // переменные обозначаем другими словами (= то же самое, что length выше)
    int position = 0; // (= то же самое, что index выше)
    while (position < count)
    {
        Console.WriteLine(col[position]); // выводим на экран позицию текущего элемента
        position++;
    }
}


int IndexOf(int[] collection, int find) // ищем индекс find в рандомном массиве
// IndexOf - название функции, int[]collection - массив, int find - элемент массива
{
    int count = collection.Length; 
    int index = 0; 
    int position = -1; /* новая переменная, куда мы положим значение искомого индекса,
    ставим -1, чтобы, если эл-та с таким значением нет в массиве – отобразилось -1*/
    
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index; // кладём инндекс в новую пересенную 
            break;
        }
        index++;
    }
    return position; // возвращаем значение
}

int[] array = new int[10]; // обозначили массив array. По умолчанию все 0-и, выше задаём рандомные значения элементам массива (FillArray) и выводим их (PrintArray)

FillArray(array); //назначает элементы в массив
array[7] = 4; // сами можем добавить определённое значение на определённое место
array[8] = 4;
array[9] = 4;
PrintArray(array); //распечатывает массив
Console.WriteLine(); //  выводим пустую строчку

int pos = IndexOf(array, 4); // новая переменная равна значению функции + ищем 4ый элемент
Console.WriteLine(pos);