// Задайте массив вещественных чисел. Найдите разницу между мах и мин элементами массива.


double[] array = {1,7,22,2,78};
double result = 0;
double max = array[0];
double min = array[4];

for (int i = 0; i < array.Length; i++)
{
 
    if (array[i] > max)
    {
        max =array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }

    result = max - min;
}
    Console.WriteLine(result);

