@echo off

set projectpath=../src/DevSkill.DevTeam/DevSkill.DevTeam.Web
set context[0]=ApplicationDbContext
set context[1]=MembershipDbContext
set context[2]=FoundationDbContext

:updatedb
cls
echo DbContexts List:
echo     0. Update All
set /a counter=1

setlocal enabledelayedexpansion

for /l %%n in (0,1,2) do (
	echo     !counter!. !context[%%n]!
	set /a counter=counter+1
)

endlocal
echo     4. Exit
echo.

set /p choice="Enter Option: "

cls

if %choice% leq 4 (goto options) else (goto wronginput)

:options
if %choice% equ 4 (goto exitt)
if %choice% equ 0 (goto runallcontexts) else (goto runonecontext)

:runallcontexts
echo Updating All DbContexts...
set /a counter=0
setlocal enabledelayedexpansion

for /l %%n in (0,1,2) do (
	echo.
	echo Updating !context[%%n]!...
	echo. 
	
	if %%n equ 0 (dotnet ef database update --project !projectpath! --context !context[%%n]!) else (dotnet ef database update --no-build --project !projectpath! --context !context[%%n]!)
	
	set /a counter=counter+1
)

endlocal
goto repeat

:runonecontext
set /a inp=%choice%-1

setlocal enabledelayedexpansion

echo.
echo Updating !context[%inp%]!...
echo.
dotnet ef database update --project !projectpath! --context !context[%inp%]!

endlocal
goto repeat

:wronginput
echo.
echo Wrong input.
goto repeat

:repeat
echo.
set /p choice="Press Enter for main menu..."
goto updatedb

:exitt
exit /b