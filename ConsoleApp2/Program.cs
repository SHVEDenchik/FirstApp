using System;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string LastName, string Login, int LoginLenght, bool HasPet, double PetAge, string[] favColors, double Age) User;     //создаем кортеж

        for (int countUsers = 0; countUsers < 3; countUsers++)                                                                              // делаем три итерации для трех пользователей
        {

            Console.WriteLine("Введите ваше имя");
            User.Name = Console.ReadLine();                                                                                                //записываем данные в поле кортежа

            Console.WriteLine("Введите вашу фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Укажите ваш логин");
            User.Login = Console.ReadLine();

            User.LoginLenght = User.Login.Length;

            Console.WriteLine("Укажите, есть ли у Вас домашнее животное? Да / нет");
            var result = Console.ReadLine();
            if (result == "Да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }

            Console.WriteLine("Укажите Ваш возраст");
            User.Age = double.Parse(Console.ReadLine());                //Парсим введенную строку в формат double

            User.favColors = new string[3];                             // элемент кортежа как созданный масив из 3 значений
            Console.WriteLine("Укажите 3 своих любимых цвета");

            for (int i = 0; i < User.favColors.Length; i++)
            {
                User.favColors[i] = Console.ReadLine();
            }
        }
    }
}