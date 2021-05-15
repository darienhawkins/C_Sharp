# Updated 20160513

Set-Variable -Name featuresToInstall -Value DHCP,RSAT-DHCP,Hyper-V,RSAT-Hyper-V-Tools,Hyper-V-PowerShell,Hyper-V-Tools

Foreach ($f in $featuresToInstall)
{
    Add-WindowsFeature -Name $f
} 

Start-Sleep -s 2

Restart-Computer