/* Задача 38**: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным вещественной частью элементов массива.
[3.1, 77.01, 22.002] => 0.1 - 0.002 = 0.098
*/
// Метод: Создаем массив из вещественных значений с фиксированным количеством знаков после запятой
double [] CreateArray(int size, int min, int max, int roundUp){
    double [] array = new double [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max) + Math.Round(rand.NextDouble(), roundUp);
    }
    return array;}

// Метод: Создаем строку изчисел массива через запятую для вывода на экран (консоль)
string Print(double [] array){
    return string.Join(", ", array);}

(double minRealName, double maxRealName) FindMaxMin_RealPart(double [] array){
    double minReal = array[0] - Math.Floor(array[0]);
    double maxReal = array[0] - Math.Floor(array[0]);
/*    foreach (int el in array)
    {
        minReal = (minReal > (el - Math.Floor(el))) ? (el - Math.Floor(el)):minReal;
        maxReal = (maxReal < (el - Math.Floor(el))) ? (el - Math.Floor(el)):maxReal;
    }
    */
    for (int i = 1; i < array.Length -1; i++)
    {
        if (minReal > (array[i] - Math.Floor(array[i])))
        {
            minReal = array[i] - Math.Floor(array[i]);
        }
        if (maxReal < (array[i] - Math.Floor(array[i])))
        {
            maxReal = array[i] - Math.Floor(array[i]);
        }
    }
    return (minRealName : minReal, maxRealName : maxReal);
}
double [] array = CreateArray(5, 0, 150, 4);

Console.WriteLine($"[{Print(array)}]");

var realPart = FindMaxMin_RealPart(array);

Console.WriteLine($"Максимальное значение вещественной части {Math.Round(realPart.Item1, 4)}"); // по элементно
Console.WriteLine($"Минимальное значение вещественной части {Math.Round(realPart.Item2, 4)}"); // а ниже с помощью именованных значений
Console.WriteLine($"Разница этих значений = {Math.Round((realPart.maxRealName - realPart.minRealName), 4)}");
