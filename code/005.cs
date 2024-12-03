trayIcon      = new NotifyIcon();
trayIcon.Text = "Я везде!";
trayIcon.Icon = TheIcon

// Add menu to the tray icon and show it.
trayIcon.ContextMenu = trayMenu;
trayIcon.Visible     = true;

Visible       = false; // Hide form window.
ShowInTaskbar = false; // Remove from taskbar.
