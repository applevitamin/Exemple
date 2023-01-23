// // Вид 1 
Console.Clear();
// void Method1()
// {
//     Console.WriteLine("Вид 1 - Автор Я!");
// }
// Method1();


//Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"Вид 2 - Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(count: 4, msg: "New text");

// Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;

// }
// int year = Method3();
// Console.WriteLine(year);

// //вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z ");
// Console.WriteLine(res);


//цикл for

// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z ");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// Дальше. У нас есть сам текст. Можете в чат написать или в комментариях написать, о том
// узнали ли вы произведения, откуда взят этот текст? И дальше мы уже начинаем писать код.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123...
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPos = i;


        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPos]) minPos = j;
        }


        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

