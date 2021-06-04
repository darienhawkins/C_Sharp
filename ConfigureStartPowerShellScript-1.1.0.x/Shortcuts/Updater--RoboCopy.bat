# DATE UPDATED: 13 May 2016

# Update Endpoint Protection
"Tools\System Center 2012 Endpoint Protection(UPDATE)\mpam-feX64.exe"

set soureurl=\\share.obfuscatedcompanydomain.local\Shares\M_Project\Virtual_Machines\Hyper-V
# set soureurl=%cd%

set destpath=C:\Virtual_Machines\Hyper-V
set destsrce=source
set destprnt=VHDX_Parents\WorkingParentChilds
set deststpr=\VHDX_Parents\StaticParents
set destscut=shortcuts
set desttool=tools

# set copyargs=/E /J /W:1 /R:1

del %destpath%\%deststpr%\*win*
del %destpath%\%destprnt%\*win*
del %destpath%\%destsrce%\win*
del %destpath%\%destscut%\*.ps1
del %destpath%\%destscut%\*.exe
del %destpath%\%desttool%\*.*

robocopy %soureurl%\%deststpr%\ %destpath%\%deststpr%\ *win*
robocopy %soureurl%\%destprnt%\ %destpath%\%destprnt%\ *win*
robocopy %soureurl%\%destsrce%\ %destpath%\%destsrce%\ win*
robocopy %soureurl%\%destscut%\ %destpath%\%destscut%\ *.ps1
robocopy %soureurl%\%destscut%\ %destpath%\%destscut%\ *.exe
robocopy %soureurl%\%desttool%\ %destpath%\%desttool%\ *.*

PAUSE
