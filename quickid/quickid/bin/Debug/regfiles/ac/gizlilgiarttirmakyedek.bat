@echo off
reg export "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer" "C:\quickid\backup\Gizliliği Arttırmak İçin\1.reg"

reg export "KEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SQMClient\Windows" "C:\quickid\backup\Gizliliği Arttırmak İçin\2.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\HandwritingErrorReports" "C:\quickid\backup\Gizliliği Arttırmak İçin\3.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DataCollection" "C:\quickid\backup\Gizliliği Arttırmak İçin\4.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection" "C:\quickid\backup\Gizliliği Arttırmak İçin\5.reg"

reg export "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat" "C:\quickid\backup\Gizliliği Arttırmak İçin\6.reg"

exit
