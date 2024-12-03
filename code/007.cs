using System;
using System.Diagnostics;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Укажите путь к вашему приложению
                string applicationPath = @"C:\Path\To\Your\1.exe";

                // Создаем процесс
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = applicationPath,
                    // При необходимости можно указать аргументы
                    // Arguments = "Тут агрументы",
                    UseShellExecute = false,
                    CreateNoWindow = true // Установите в true, если не хотите показывать окно
                };

                using (Process process = Process.Start(startInfo))
                {
                    // Если нужно, можно дождаться завершения процесса
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
