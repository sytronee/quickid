@echo off
schtasks /Delete /TN "Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\ProgramDataUpdater" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\StartupAppTask" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\AitAgent" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\ProgramDataUpdater" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser (UR)" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\StartupAppTask" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\AitAgent" /F
schtasks /Delete /TN "Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser (UR)" /F

schtasks /Delete /TN "Microsoft\Windows\Customer Experience Improvement Program\Consolidator" /F
schtasks /Delete /TN "Microsoft\Windows\Customer Experience Improvement Program\KernelCeipTask" /F
schtasks /Delete /TN "Microsoft\Windows\Customer Experience Improvement Program\Uploader" /F
schtasks /Delete /TN "Microsoft\Windows\Customer Experience Improvement Program\UsbCeip" /F

schtasks /Delete /TN "Microsoft\Windows\Feedback\Siuf\AutoLogger-Diagtrack-Listener" /F
schtasks /Delete /TN "Microsoft\Windows\Feedback\Siuf\AutoLogger-Diagtrack-Listener" /F
schtasks /Delete /TN "Microsoft\Windows\Feedback\Siuf\BackgroundTaskHandler" /F
schtasks /Delete /TN "Microsoft\Windows\Feedback\Siuf\BackgroundTaskHandler" /F
schtasks /Delete /TN "Microsoft\Windows\Feedback\Siuf\ScheduledTask" /F

schtasks /Delete /TN "Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector" /F
