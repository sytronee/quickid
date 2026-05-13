@echo off

reg export "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management" "C:\quickid\backup\RyzenPerfomans\1.reg"

reg export "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem" "C:\quickid\backup\RyzenPerfomans\2.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile" "C:\quickid\backup\RyzenPerfomans\3.reg"

exit