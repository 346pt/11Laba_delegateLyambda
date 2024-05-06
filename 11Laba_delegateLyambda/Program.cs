using System;

delegate string DayOfWeekDelegate();
class Program {
    static void Main(string[] args) {

        string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int currentIndex = 0;

        DayOfWeekDelegate getDay = () =>
        {
            string day = Days[currentIndex];
            currentIndex = (currentIndex + 1) % Days.Length;
            return day;
        };

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(getDay());
        }
        Console.ReadKey();
    }
}