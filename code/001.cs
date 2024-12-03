using System;
using System.Diagnostics;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Application.Run(new Form1());
    }
}

public class Form1 : Form
{
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == (Keys.Alt | Keys.F4))
        {
            // Перезагрузка компьютера
            Process.Start("shutdown", "/r /t 0");
            return true; // Возвращаем true для остановки события
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }
}
