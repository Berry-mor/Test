//Первоначальный (Входной) массив
String[] arrayString = { "Hello", ":-)", "2", "world"};

// Определение размерности выходного массива
int SizeArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        string temp = arrayString[i];
        if (temp.Length <= 3)
        {
            count++;
        }
    }

    return count;
}

//Формирование выходного массива

String[] NewArrayString(int sizeArray, string[] arrayString)
{
    String[] newArray = new String[sizeArray];
    int c = 0;

    for (int b = 0; b < arrayString.Length; b++)
    {
        string temp = arrayString[b];
        if (temp.Length <= 3)
        {

            newArray[c] = temp;
            c++;

        }

    }

    return newArray;
}


int sizeArray = SizeArray(arrayString);

//Печать нового массива

Console.Write("[");
String[] arr = NewArrayString(sizeArray, arrayString);
for (int i = 0; i < arr.Length; i++)
    Console.Write("\"{0}\", ", arr[i]);
Console.Write("]");
