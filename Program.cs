// Итоговая проверочная работа:
// Написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна трем символам.
Console.Clear();
string[] array1 = new string[5] {"yes", "no", "hello", "world", "qwerty"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}