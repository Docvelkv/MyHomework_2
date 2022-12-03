// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
bool res = int.TryParse(Console.ReadLine(), out int num);
if ( res == true) {
    Console.WriteLine("Первый способ");
    if ( num < 100 & num > -100 ) Console.WriteLine($"В ведённом числе {num} нет третьей цифры.");
    else {
        int mod = num;
        while ( mod > 999 || mod < -999 ) mod = mod / 10;    // получаем трёхзначное число
        mod = mod % 10;                                     // находим остаток от деления на 10
        if ( mod < 0 ) mod = mod * -1;                       // если число было отрицательное
        Console.WriteLine($"Третья цифра введённого числа {num} - {mod}");}

    Console.WriteLine("Второй способ");
    if ( num < 100 && num > -100 ) Console.WriteLine($"В ведённом числе {num} нет третьей цифры.");
    else {
        string snum = num.ToString();
        if ( num > 0 ) Console.WriteLine($"Третья цифра введённого числа {num} - {snum[2]}");
        if ( num < 0 ) Console.WriteLine($"Третья цифра введённого числа {num} - {snum[3]}");}
}
else Console.WriteLine("Вы ввели не число");