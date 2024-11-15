using System;

class Program
{
    static void Main()
    {
        // Получаем ед экземпляр
        var logger = Logger.GetInstance();

        // Выводим несколько событий 
        logger.Log(Logger.Severity.NORMAL, "Система запущена");
        logger.Log(Logger.Severity.NOTE, "Процесс завершен с предупреждениями");
        logger.Log(Logger.Severity.ERROR, "Произошла ошибка в модуле 3");
        logger.Log(Logger.Severity.NORMAL, "Пользователь вошел в систему");

        // Выводим 10 последних
        logger.PrintLastEvents();

        // Доп события
        logger.Log(Logger.Severity.NORMAL, "Сессия завершена");
        logger.Log(Logger.Severity.ERROR, "Не удалось подключиться к базе данных");
        logger.Log(Logger.Severity.NOTE, "Прочитано 5 новых сообщений");

        // Выводим последние события снова
        Console.WriteLine("\nПосле добавления новых событий:");
        logger.PrintLastEvents();
    }
}
