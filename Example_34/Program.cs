/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
// Метод: Создаем массив из size-количества элементов 
// и заполняем случайными числами из промежутка [min, max]
int [] CreateArray(int size,int min, int max){
    int [] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max+1);
    }
    return array;}

// Метод: Создаем строку изчисел массива через запятую для вывода на экран (консоль)
string Print(int [] array){
    return string.Join(", ", array);}

//
int GetEvenNumber(int [] array){ 
    int evenNumber =0; 
    foreach (int el in array)
    {
        evenNumber += (el % 2) == 0 ? 1:0;
    }
    return evenNumber;
} 

int [] array = CreateArray(8, 100, 999);
int evNumb = GetEvenNumber(array);
Console.WriteLine($"[{Print(array)}]");
Console.WriteLine($"Количество четных чисел в массиве => {evNumb}");