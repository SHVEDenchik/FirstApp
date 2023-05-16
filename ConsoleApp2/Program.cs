internal class Program
{
    static void Main(string[] args)
    {
        var name = "Max";

        Console.Write("Сколько Вам лет?");
        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Ваше имя {0} и Ваш возвраст {1} ", name, age);

        Console.Write("Какой Ваш любимый день недели? ");

        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Ваш любимый день недели {0}", day);
    }
}