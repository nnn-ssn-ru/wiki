using Microsoft.Win32;
using System;

class Program {
    static void Main() {
        string filePath = @"C:\Путь\До\Файл.exe"; // Укажите полный путь к вашему файлу

        try {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true)) {
                if (key != null) {
                    key.SetValue("Shell", key.GetValue("Shell") + "," + filePath);
                }
            }
        }
        catch (Exception ex) {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
