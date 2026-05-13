@echo off

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR" "C:\quickid\backup\OyunPerformas\1.reg"

reg export "HKEY_CURRENT_USER\System\GameConfigStore" "C:\quickid\backup\OyunPerformas\2.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GameDVR" "C:\quickid\backup\OyunPerformas\3.reg"

reg export "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR" "C:\quickid\backup\OyunPerformas\4.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile" "C:\quickid\backup\OyunPerformas\5.reg"

reg export "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power\PowerSettings\54533251-82be-4824-96c1-47b60b740d00\943c8cb6-6f93-4227-ad87-e9a3feec08d1" "C:\quickid\backup\OyunPerformas\6.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games" "C:\quickid\backup\OyunPerformas\7.reg"





