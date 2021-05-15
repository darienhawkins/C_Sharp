# Create required VM switches
New-VMSwitch -Name Privnet -SwitchType Private
New-VMSwitch -Name RDPAccess -SwitchType Internal
New-VMSwitch -Name ExternalAccess -SwitchType Private

# Create DHCP Scope
Add-DhcpServerv4Scope -EndRange 192.168.222.222 -Name RDPAccess -StartRange 192.168.222.222 -SubnetMask 255.255.255.0 -LeaseDuration 8.00:00:00 -State Active -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-07 -IPAddress 192.168.222.7 -ScopeId 192.168.222.0 -Name win7 -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-08 -IPAddress 192.168.222.8 -ScopeId 192.168.222.0 -Name win8 -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-10 -IPAddress 192.168.222.10 -ScopeId 192.168.222.0 -Name win10 -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-17 -IPAddress 192.168.222.17 -ScopeId 192.168.222.0 -Name win7dup -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-18 -IPAddress 192.168.222.18 -ScopeId 192.168.222.0 -Name win8dup -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-20 -IPAddress 192.168.222.20 -ScopeId 192.168.222.0 -Name win10dup -Type Dhcp

# Copy required files
Copy-Item -Force -Recurse ..\..\..\Virtual_Machines c:\ -PassThru

# Create MedusaMV
Set-Variable -Name MedusaVHDX -Value 20160112_MedusaC.vhdx
Set-Variable -Name MedusaName -Value MedusaC
Set-Variable -Name MedusaPath -Value C:\Virtual_Machines\Hyper-V\$MedusaName
Set-Variable -Name MedusaNetwork -Value ExternalAccess
Set-Variable -Name PrivNetNetwork -Value Privnet
New-VM -VHDPath $MedusaPath\$MedusaVHDX -Generation 1 -MemoryStartupBytes 512MB -Name $MedusaName -Path $MedusaPath -SwitchName $MedusaNetwork
Add-VMNetworkAdapter -VMName $MedusaName -SwitchName $PrivNetNetwork

