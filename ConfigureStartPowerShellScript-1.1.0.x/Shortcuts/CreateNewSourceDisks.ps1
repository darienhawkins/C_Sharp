Set-Variable -Name win7parent -Value "20160111@1730_Windows_Win7_Ent_SP1_PowerShell_4.0_IE11_LangPacks.vhdx"
Set-Variable -Name win7source -Value "Win7source.vhdx"

Set-Variable -Name win8parent -Value "20160111@1730_Windows_Win8.1_Ent_VLK_LangPacks.vhdx"
Set-Variable -Name win8source -Value "Win8source.vhdx"

Set-Variable -Name win10parent -Value "20160111@1730_Windows_Win10_Ent_LangPacks.vhdx"
Set-Variable -Name win10source -Value "Win10source.vhdx"

# create new working parents from static parents
<#
New-VHD -ParentPath c:\Virtual_Machines\Hyper-V\VHDX_Parents\StaticParents\$win7parent -Path C:\Virtual_Machines\Hyper-V\VHDX_Parents\WorkingParentChilds\$win7parent -Differencing
New-VHD -ParentPath c:\Virtual_Machines\Hyper-V\VHDX_Parents\StaticParents\$win8parent -Path C:\Virtual_Machines\Hyper-V\VHDX_Parents\WorkingParentChilds\$win8parent -Differencing
New-VHD -ParentPath c:\Virtual_Machines\Hyper-V\VHDX_Parents\StaticParents\$win10parent -Path C:\Virtual_Machines\Hyper-V\VHDX_Parents\WorkingParentChilds\$win10parent -Differencing
#>

# create new sources from working parents
<#
New-VHD -ParentPath C:\Virtual_Machines\Hyper-V\VHDX_Parents\WorkingParentChilds\$win7parent -Path C:\Virtual_Machines\Hyper-V\Source\$win7source -Differencing
New-VHD -ParentPath C:\Virtual_Machines\Hyper-V\VHDX_Parents\WorkingParentChilds\$win8parent -Path C:\Virtual_Machines\Hyper-V\Source\$win8source -Differencing
New-VHD -ParentPath C:\Virtual_Machines\Hyper-V\VHDX_Parents\WorkingParentChilds\$win10parent -Path C:\Virtual_Machines\Hyper-V\Source\$win10source -Differencing
#>