// Вид 1
// void Method1()
// {
//     Console.WriteLine("Autor...");
// }
// Method1();

// Вид 2
// 1)
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"Текст сообщения");

// 2)
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //увеличение на 1 называется инкремент, уменьшение декремент
//     }
// }
// Method21("Текст", 4);
// Method21(count: 4, msg: "New"); //таким образом можно аргументы менять местами

//Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

                                // Цикл FOR

// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
//     for(int i = 0;i<count;i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

                        // Цикл в цикле

// Console.WriteLine(res);



// for(int i = 1; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }



                                // Тренировочная задача


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// // string s = “qwerty”
// //             012345
// // s[3] // r
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length; //опредение длины строки
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result +$"{newValue}";
//         else result = result +$"{text[i]}";
//     } 
//     return result;
// }

// string newText = Replace(text,  ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,  'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,  'В', 'в');
// Console.WriteLine(newText);


//                                 Упорядочивание массивов. Сортировка

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPozition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPozition]) minPozition = j;
        }        
        int temporary = array[i];
        array[i] = array[minPozition];
        array[minPozition] = temporary;


    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

