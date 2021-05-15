# Updated 20160513

Set-Variable -Name deleteVirtMachinePath -Value "C:\Virtual_Machines\Hyper-V\Machines\*"
Set-Variable -Name procsToKill -Value mstsc*,vmconnect*

Foreach ($b in $procsToKill)
{
    Stop-Process -Name $b -Force -ErrorAction SilentlyContinue
}

Stop-VM -Name Mach* -Force -TurnOff -ErrorAction SilentlyContinue
Remove-VM -Name Mach* -Force -ErrorAction SilentlyContinue
Remove-Item -Path $deleteVirtMachinePath -Force -Recurse
# Start-VM -Name Med*
Stop-Process -Name powershell -Force -ErrorAction SilentlyContinue