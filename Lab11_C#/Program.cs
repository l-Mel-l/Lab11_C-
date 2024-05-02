public class Program{
    // Создаем делегат
    public delegate string DayDelegate();

    static void Main(){
        // Массив с названиями дней недели
        string[] daysOfWeek = ["Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"];
        int dayIndex = 0; // начальный индекс массива - 0

        // Создаем экземпляр делегата с помощью лямбда-выражения
        DayDelegate day = () => {
            // Возвращаем текущий день недели
            string currentDay = daysOfWeek[dayIndex];

            // Увеличиваем индекс на 1 или сбрасываем его на 0 (Понедельник), если достигли конца массива
            dayIndex += 1;
            if (dayIndex >= daysOfWeek.Length) { dayIndex = 0; }

            // Возвращаем название следующего дня недели
            return currentDay;
        };

        for(int i = 0; i<14; i++){
            Console.WriteLine(day()); 
            Console.WriteLine("-------------\n"); 
        }
    }
}