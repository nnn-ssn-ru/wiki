---
### Блокировка диспетчера задач
##### Путь: `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System`
##### Значение: `DisableTaskMgr: DWORD = 1`
---
### Блокировка режимов питания:
##### Путь: `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer`
##### Значение: `NoClose: DWORD = 1`
---
### Блокировка среды восстановления:
##### Путь: `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System`
##### Значение: `DisableRSC: DWORD = 1`
##### Путь: `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Policies\System`
##### Значение: `DisableRecovery: DWORD = 1`
---
### Блокировка Ctrl+Alt+Del
##### Путь: `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System`
##### Значение: `DisableLogoff: DWORD = 1`
---
### Блокировка Alt+Tab
##### Путь: `HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer`
##### Значение: `NoAltTab: DWORD = 1`
---
### Смена кнопок мыши
##### Путь: `HKEY_CURRENT_USER\Control Panel\Mouse`
##### Значение: `SwapMouseButtons: DWORD = 1`
---
### Блокировка клавиатуры
##### Путь: `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Keyboard Layout`
##### Значение: `Scancode Map: Binary = 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 00 00`
---
### Ассоциации файлов
##### Путь: `HKEY_CLASSES_ROOT\.myexe`
##### Значение: `default: String = "C:\\path\to\file.exe"`
---
### Блокировка программ
##### Путь: `HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\currentversion\file.name`
##### Значение: `debugger: String = "NNN"`
---
