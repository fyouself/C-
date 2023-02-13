// // // // See https://aka.ms/new-console-template for more information
// // // Console.WriteLine("Hello, World!");







// // //=====Работа с текстом
// // // Дан текст. В тексте нужно все пробелы заменить чёрточками,
// // // маленькие буквы “к” заменить большими “К”,
// // // а большие “С” маленькими “с”.
// // // Ясна ли задача?


// // // string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// // // + "ежели бы вас послали вместо нашего милого Винценгероде,"
// // // + "вы бы взяли приступом согласие прусского короля."
// // // + "Вы так красноречивы. Вы дадите мне чаю?";

// // // string Replace(string oldText, char oldValue, char newValue)
// // // {
// // //      string resalt = string.Empty;
// // //     for (int i = 0; i < oldText.Length; i++)
// // //     {
// // //         if (oldText[i] == oldValue) resalt = resalt + newValue;
// // //         else resalt = resalt + oldText[i];
// // //     }
// // //     return resalt;
// // // }

// // // string newText = Replace(text, 'с', '6');

// // // System.Console.WriteLine(newText);







// //  Упорядочивание массива

// // int PutNumber(string text)
// // {
// //     System.Console.Write(text);
// //     int a = Convert.ToInt32(Console.ReadLine());
// //     return a;
// // }

// // int[] AddRandomArray(int Size, int leftLimit, int rigthLimit)
// // {
// //     int[] newArray = new int[Size];

// //     for (int i = 0; i < Size; i++)
// //     {
// //         newArray[i] = new Random().Next(leftLimit, rigthLimit);
// //     }
// //     return newArray;
// // }

// // void selectionArray(int[] oldArray)
// // {
// //     for (int i=0; i< oldArray.Length; i++)
// //     {
// //         int minPosition = i;

// //         for(int j = i+1; j<oldArray.Length; j++)
// //         {
// //             if(oldArray[j]<oldArray[minPosition]) minPosition=j;
// //         }

// //         int temp = oldArray[i];
// //         oldArray[i] =oldArray[minPosition];
// //         oldArray[minPosition] = temp;
// //     }
// // }

// // int Size = PutNumber("Введите развер массива: ");
// // int leftLimit = PutNumber("Введите левую границу чисел: ");
// // int rigthLimit = PutNumber("Введите правую границу чисел: "); 

// // int[] new_array = AddRandomArray(Size, leftLimit, rigthLimit);

// // System.Console.WriteLine("Ваш массив чисел [" + string.Join(", ", new_array) + "]");

// // selectionArray(new_array);
// // System.Console.WriteLine("[" + string.Join(", ", new_array) + "]");






// // Код для персонального приветствия

// // Console.Write ("Введите имя пользователя: " );
// // string username = Console.ReadLine ();
// // if(username.ToLower() == "маша")
// // {
// // System.Console.WriteLine("Ура, это же МАША");
// // }
// // else
// // {
// // System.Console.Write("Привет, ");
// // System.Console.WriteLine(username);
// // }



// // Команда, которая будет «рисовать».

// Console.Clear();
// void Print(int a, int b)
// {
// Console.SetCursorPosition(a,b);
// Console.Write("o");
// }

// int xa = 40;
// int ya = 1;

// int xb = 1;
// int yb = 20;

// int xc = 80;
// int yc = 20;

// Print(xa,ya); Print(xb,yb); Print(xc,yc);

// // int x = xa;
// // int y = ya;

// // for(int i = 1; i<2000;i++)
// // {
// //     int randomNumber = new Random().Next(0,3);
// //     if (randomNumber==0)
// //     {
// //         x = (x + xa)/2;
// //         y = (y + ya)/2;
// //         Print(x,y);
// //     }
// //     else if (randomNumber==1)
// //     {
// //          x = (x + xb)/2;
// //         y = (y + yb)/2;
// //         Print(x,y);
// //     }
// //      else if (randomNumber==2)
// //     {
// //          x = (x + xc)/2;
// //         y = (y + yc)/2;
// //         Print(x,y);
// //     }
// // }
