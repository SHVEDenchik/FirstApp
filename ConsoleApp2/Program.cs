using System;

class Program
{
    static void Main(string[] args)
    {
        var userData = GetDataFromUser();
        ShowUserData(userData);
    }

    static (string firstName, string lastName, int age, string[] petsNames, string[] colors) GetDataFromUser()      //создаем кортеж Имя, Фамилия, Возраст, клички животных, любимые цвета
    {
        Console.WriteLine("Введите имя:");
        string firstName = Console.ReadLine();                                                                      // читаем имя в переменную

        Console.WriteLine("Введите фамилию:");
        string lastName = Console.ReadLine();                                                                       // читаем фамилию в переменную

        Console.WriteLine("Введите возраст (целое число больше 0):");
        int age = GetValidIntFromUser();                                                                            // для возраста вызываем метод проверки

        string[] petsNames = null;
        Console.WriteLine("Есть ли у вас питомец? (Да/Нет)");
        string answer = Console.ReadLine().ToLower();                                                               // читаем ответ про животных и переводим в нижний регистр
        if (answer == "да")                                                                                         // если да, выполняем блок кода с записью колличества
        {
            Console.WriteLine("Введите количество питомцев (целое число больше 0):");
            int petsCount = GetValidIntFromUser();                                                                  // проверяем введенное колличество питомцев методом
            petsNames = GetPetsNames(petsCount);                                                                    // записываем в массив данные, которые получим в отдельном методе
        }

        Console.WriteLine("Введите количество любимых цветов (целое число больше 0):");
        int colorsCount = GetValidIntFromUser();                                                                    // проверяем цифру в колличестве любимых цветов 
        string[] colors = GetColorsFromUser(colorsCount);                                                           // записываем в массив цвета, полученные в другом методе                         

        return (firstName, lastName, age, petsNames, colors);                                                       // возвращаем Имя, Фамилию, возраст, массивы с питомцами и цветами
    }

    static int GetValidIntFromUser()                                                                                // метод проверки корректности введенных цифр
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)                                        // выполняем блок кода, пока не введут целочисленное и больше 0
        {                                                                                                           // ! - для инверсии возвращаемого значения
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");                                            // т.е. пока мы не можем преобразовать в число, или значение меньше / равно 0
                                                                                                                    // для while возвращается true и код продолжает выполняться
        }
        return result;
    }

    static string[] GetPetsNames(int count)                                                                         // метод собирающий в массив клички питомцев
    {
        string[] names = new string[count];                                                                         // создаем массив с кличками = коллчеству питомцев
        for (int i = 0; i < count; i++)                                                                             // циклом спрашиваем про каждого питомца и записываем в массив
        {
            Console.WriteLine($"Введите кличку питомца {i + 1}:");
            names[i] = Console.ReadLine();
        }
        return names;                                                                                           
    }

    static string[] GetColorsFromUser(int count)                                                                    // то же что и выше
    {
        string[] colors = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите любимый цвет {i + 1}:");
            colors[i] = Console.ReadLine();
        }
        return colors;
    }

    static void ShowUserData((string firstName, string lastName, int age, string[] petsNames, string[] colors) userData)                                    // метод вывода данных о пользователе
    {
        Console.WriteLine("Ваши данные:\n" +
            "Имя: {0}\n" +
            "Фамилия: {1}\n" +
            "Возраст: {2}\n" +
            "Питомцы: {3}\n" +
            "Любимые цвета: {4}", userData.firstName, userData.lastName, userData.age,
            (userData.petsNames.Length > 0 ? string.Join(", ", userData.petsNames) : "нет"),                                                                // Если нет питомцев, то выводим НЕТ
            (userData.colors.Length > 0 ? string.Join(", ", userData.colors) : "нет"));                                                                     // если есть, то джойним в одну строку 
    }                                                                                                                                                       // с разделителем запятая
}