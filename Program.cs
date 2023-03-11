// Написать программу, которая из имеющегося массива строк формирует масив из строк, длина которых мньше или равна 3 символа.
// Первоначально масив вводиться с клавиатуры.

Console.Clear();
Console.Write("Введите длину массива :  ");
int i= int.Parse(Console.ReadLine()!);
Console.WriteLine();
string [] list=new string[i];

for (int k=0; k<i; k++)
{ 
    Console.Write(k+"  Ведите текстовое или цифровое значение в массив : ");
    list[k]=Console.ReadLine()!;
}

var result = list.Where(x => x.Length <= 3).ToArray(); 
Console.WriteLine();
Console.WriteLine(string.Join(", ", result)); 
Console.WriteLine();