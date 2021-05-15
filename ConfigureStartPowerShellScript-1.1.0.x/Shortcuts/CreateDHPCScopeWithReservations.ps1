Add-DhcpServerv4Scope -EndRange 192.168.222.222 -Name RDPAccess -StartRange 192.168.222.222 -SubnetMask 255.255.255.0 -LeaseDuration 8.00:00:00 -State Active -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-07 -IPAddress 192.168.222.7 -ScopeId 192.168.222.0 -Name win7 -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-08 -IPAddress 192.168.222.8 -ScopeId 192.168.222.0 -Name win8 -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-10 -IPAddress 192.168.222.10 -ScopeId 192.168.222.0 -Name win10 -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-17 -IPAddress 192.168.222.17 -ScopeId 192.168.222.0 -Name win7dup -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-18 -IPAddress 192.168.222.18 -ScopeId 192.168.222.0 -Name win8dup -Type Dhcp
Add-DhcpServerv4Reservation -ClientId aa-aa-aa-aa-aa-20 -IPAddress 192.168.222.20 -ScopeId 192.168.222.0 -Name win10dup -Type Dhcp