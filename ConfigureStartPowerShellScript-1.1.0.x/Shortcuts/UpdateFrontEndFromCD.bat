# Updated 20160513
# Update front-end code and SCEP

taskkill /f /im mstsc.exe
taskkill /f /im conf*

# Update Endpoint Protection
"System Center 2012 Endpoint Protection(UPDATE)\mpam-feX64.exe"

# sleep for two seconds
powershell start-sleep -s 2

# Copy .exe and start
copy %cd%\conf*.exe C:\Virtual_Machines\Hyper-V\Shortcuts\
C:\Virtual_Machines\Hyper-V\Shortcuts\ConfigureStartPowerShellScript-01.exe

