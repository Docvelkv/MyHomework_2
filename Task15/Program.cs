// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным
Console.Clear();
Console.Write("Введите цифру дня недели: ");
int numday = int.Parse(Console.ReadLine());
if ( numday < 8 && numday > 0) {
    if ( numday >= 6) Console.WriteLine("Этот день выходной.");
    else Console.WriteLine("Этот день не выходной.");}
else Console.WriteLine("В неделе 7 дней.");