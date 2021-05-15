Set-Variable -Name MedusaName -Value MedusaC
Set-Variable -Name MedusaPath -Value C:\Virtual_Machines\Hyper-V\$MedusaName
Set-Variable -Name MedusaNetwork -Value ExternalAccess
Set-Variable -Name PrivNetNetwork -Value Privnet
New-VM -VHDPath $MedusaPath\MedusaC.vhdx -Generation 1 -MemoryStartupBytes 512MB -Name $MedusaName -Path $MedusaPath -SwitchName $MedusaNetwork
Add-VMNetworkAdapter -VMName $MedusaName -SwitchName $PrivNetNetwork