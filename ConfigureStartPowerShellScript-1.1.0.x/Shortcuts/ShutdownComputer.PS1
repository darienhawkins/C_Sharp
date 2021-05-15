# Updated 20160513

Set-Variable -Name deleteVirtMachinePath -Value "C:\Virtual_Machines\Hyper-V\Machines\*"
Set-Variable -Name vmsToKill -Value Medusa*,Mach*
Set-Variable -Name procsToKill -Value mstsc*,vmconnect*,mmc*

Foreach ($a in $vmsToKill)
{
    Stop-VM -Name $a -Force -ErrorAction SilentlyContinue
}

Foreach ($b in $procsToKill)
{
    Stop-Process -Name $b -Force -ErrorAction SilentlyContinue
}       

Remove-VM -Name Mach* -Force -ErrorAction SilentlyContinue
Remove-Item -Path $deleteVirtMachinePath -Force -Recurse -ErrorAction SilentlyContinue

Start-Sleep -s 2

Stop-Computer -Force -ErrorAction SilentlyContinue