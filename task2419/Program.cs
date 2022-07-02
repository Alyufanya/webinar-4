// написать программу, которая принимает число и выдает сумму от числа до A
//Console.WriteLine("Введите число А");
//int numberA = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

//for (int i = 1; i <= numberA; i++){
  //  sum += i; //sum = sum +1
//}
//Console.WriteLine($"Сумма чисел от 1 до А = {sum}");

//Напишите программу, которая принимает на вход число и выдает количество цифр в числе

//int sumFunc (int n1){
  //  int count = 0;
  //  while (n1 > 0) {
  //      n1 = n1 / 10;
   //     count++;
 //   }
   /// return count;
//}

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int resultend = sumFunc(number);

//Console.WriteLine($"Количесто цифр в числе = {resultend}");


// int number = Convert.ToInt32(Console.ReadLine());

// int getCountDigits (int n){
//     int count = 0;
//     while (n > 0){
//         n /= 10; // n = n /10
//         count++;
//     }
//     return count;
// }

// Console.WriteLine($"Количество цифр в числе {number} = {getCountDigits(number)}");

//Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// int fact(int n){
//     if(n == 0) return 1;
//     else {
//         int F = 1;
//         for (int i = 1; i <= n; i++){
//             F *= i;
//         }
//         return F;
//     }
// }
// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());

// int multi = fact(a);

// Console.WriteLine($"Произведение чисел А = {multi}");

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,0,0]
// int [] massiv = new int [8];
// void masmetod (int [] masother){
//     Console.Write("Массив = [");
//     for (int i = 0; i <= masother.Length - 2; i++){
//         masother[i] = new Random().Next(0,2);
//         Console.Write($"{masother[1]}, ");
//         }
//         masother[masother.Length - 1] = new Random().Next(0,2);
//         Console.Write($"{masother[masother.Length - 1]}");
//         Console.Write("]");     
        
//     }
// masmetod(massiv);
