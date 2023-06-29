/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

// Метод: Создаем строку из чисел массива через запятую для вывода на экран (консоль)
string Print(int [] array){
    return string.Join(", ", array);}

int SumElOddPositions(int [] array){ 
    int sum =0; 
    for (int i = 1; i < array.Length; i=i + 2)
    {
        sum = sum + array[i];
    }
    return sum;} 
//
int [] array = CreateArray(8, -10, 15);
int sumOddPos = SumElOddPositions(array);
Console.WriteLine($"[{Print(array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях => {sumOddPos}");