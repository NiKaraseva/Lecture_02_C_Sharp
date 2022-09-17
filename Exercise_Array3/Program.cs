void FillArray(int[] collection) // Назначаем элементы в массив
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

int[] array = new int[10]; // По умолчанию все 0-и, выше задаём рандомные значения элементам массива (FillArray) и выводим их (PrintArray)

FillArray(array); //Назначает элементы в массив
PrintArray(array); //Распечатывает массив