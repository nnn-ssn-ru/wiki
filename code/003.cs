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
        return true;
    }
}
