using System;
using System.Windows.Forms;

namespace FullScreenApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Скрыть рамки
            this.WindowState = FormWindowState.Maximized; // Развернуть на весь экран
            this.TopMost = true; // Держать форму поверх остальных окон
        }

        // Запретить закрытие формы
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true; // Отменить закрытие
        }

        // Запретить перемещение формы (необходимо переопределить метод)
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int SC_CLOSE = 0xF060; // Код закытия
            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() == SC_MOVE || m.WParam.ToInt32() == SC_CLOSE))
            {
                return; // Игнорировать
            }
            base.WndProc(ref m);
        }
    }
}
