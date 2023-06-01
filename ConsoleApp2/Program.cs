using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var favcolors = new String[3];

        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor();                                 // Записываем данные в масив вызовом метода ShowColor, который считывает данные с клавиатуры
        }

        for (int i = 0;i < favcolors.Length; i++)
        {
            Console.WriteLine(favcolors[i]);
        }
    }

    static string ShowColor() => Console.ReadLine();                    // конструкция возвращает в метод прочитанную строку. То же самое что льзуем только при 1 операции в методе)
}


