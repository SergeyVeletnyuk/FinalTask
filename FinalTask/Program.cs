// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.


string[] array1 =  new string[11] {"1", "123", "Hello", "world", "53423", "555", "hey", "112", "8822", "key", "1111" };
string[] array2 = new string[array1.Length];

Array1(array1, array2);
PrintArray2(array2);


void Array1(string[] array1, string[] array2)
{
    int count = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count = count + 1;
            
        }
    }
}

void PrintArray2(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}