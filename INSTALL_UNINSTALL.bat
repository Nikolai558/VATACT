@echo off

TITLE VATACT INSTALL / UNINSTALL

:HELLO

ECHO.
ECHO.
ECHO                  **************
ECHO                   RUN AS ADMIN
ECHO                  **************
ECHO.
ECHO.
ECHO  THIS BATCH FILE WILL HELP YOU INSTALL OR UNINSTALL
ECHO  THE VATSIM ACTIVITY PROGRAM FOUND HERE:
ECHO.
ECHO  https://github.com/Nikolai558/VATACT
ECHO.
ECHO.
ECHO  CHOICE:
ECHO.
ECHO          I  -  INSTALL
ECHO          U  -  UNINSTALL
ECHO.
ECHO.

:USERSELECT1

SET /P USERSELECT=Type I or U and press enter: 
	if /I %USERSELECT%==I GOTO DIR_SETUP
	if /I %USERSELECT%==U GOTO UNINSTALL
	ECHO.
	ECHO.
	ECHO  %USERSELECT% is not a recognized response. Try again.
	ECHO.
	ECHO.
	GOTO USERSELECT1

:DIR_SETUP

CLS

ECHO.
ECHO.
ECHO  Would you like to have this program installed here?
ECHO.
ECHO       %ProgramFiles%
ECHO.
ECHO.

:USERSELECT2

SET /P USERSELECT=Type Y or N and press enter: 
	if /I %USERSELECT%==Y GOTO DEF_DIR
	if /I %USERSELECT%==N GOTO CHOOSE_DIR
	ECHO.
	ECHO.
	ECHO %USERSELECT% is not a recognized response. Try again.
	ECHO.
	ECHO.
	GOTO USERSELECT2

:DEF_DIR

CD "%ProgramFiles%"
	MKDIR "VATACT"

SET UNINSTALL_DIR=%ProgramFiles%

SET INSTALL_DIR=%ProgramFiles%\VATACT

GOTO INSTALL

:CHOOSE_DIR

CLS

ECHO.
ECHO.
ECHO  CHOOSE THE LOCATION WHERE YOU WANT TO INSTALL VATACT
ECHO.
ECHO.
ECHO  Note-In the location you choose, this BATCH file
ECHO  will make a sub-folder named "VATACT"
ECHO.
ECHO.

set "psCommand="(new-object -COM 'Shell.Application')^
.BrowseForFolder(0,'Select The Folder That You Wish To Install To',0,0).self.path""

	for /f "usebackq delims=" %%I in (`powershell %psCommand%`) do set "HOST_DIR=%%I"

CD "%HOST_DIR%"
	MKDIR "VATACT"

SET UNINSTALL_DIR=%HOST_DIR%

SET INSTALL_DIR=%HOST_DIR%\VATACT

:INSTALL

xcopy /e /i /r /k /-y "%~dp0." "%INSTALL_DIR%"

CD "%UNINSTALL_DIR%\VATACT"
MD UNINSTALL_DATA_REF

CD "%UNINSTALL_DIR%\VATACT\UNINSTALL_DATA_REF"
ECHO %UNINSTALL_DIR% >> UNINSTALL_HOST_DIR_REF.txt

CLS

ECHO.
ECHO.
ECHO  ALL CONTENT FOUND HERE:
ECHO  %~dp0
ECHO.
ECHO  HAS BEEN COPIED TO HERE:
ECHO  %INSTALL_DIR%
ECHO.
ECHO.
ECHO  WOULD YOU LIKE TO MAKE A SHORTCUT FOR THE
ECHO  MAIN .exe FILE ON YOUR DESKTOP?
ECHO.
ECHO.

:USERSELECT3

SET /P USERSELECT=Type Y or N and press enter: 
	if /I %USERSELECT%==Y GOTO MAKE_SHORTCUT
	if /I %USERSELECT%==N GOTO INSTALL_DONE
	ECHO.
	ECHO.
	ECHO %USERSELECT% is not a recognized response. Try again.
	ECHO.
	ECHO.
	GOTO USERSELECT3

:MAKE_SHORTCUT

mklink "%USERPROFILE%\Desktop\VATACT.exe" "%INSTALL_DIR%\CidCalculatorUI.exe"

:INSTALL_DONE

CLS

ECHO.
ECHO.
ECHO  ******************
ECHO   INSTALL COMPLETE
ECHO  ******************
ECHO.
ECHO.
ECHO.
ECHO  Uninstaller and the main .exe may be found here:
ECHO.
ECHO  %INSTALL_DIR%
ECHO.
ECHO.
ECHO.

PAUSE
EXIT /B

:UNINSTALL

CLS

ECHO.
ECHO.
ECHO  PRESS ANY KEY TO START THE UNINSTALL PROCESS
ECHO.
ECHO.
ECHO.
ECHO.
ECHO    *****************************************
ECHO     WHEN THE UNINSTALL PROCESS IS COMPLETE,
ECHO             THIS WINDOW WILL CLOSE
ECHO    *****************************************
ECHO.
ECHO.
ECHO.
ECHO.

PAUSE

CD "%~dp0\UNINSTALL_DATA_REF"
for /f "delims=" %%x in (UNINSTALL_HOST_DIR_REF.txt) do set UNINSTALL_DIR=%%x

CD "%USERPROFILE%\AppData\Local"
RD /s /q "Nikolai558"

CD "%USERPROFILE%\Desktop"
IF EXIST VATACT.exe DEL /s /q VATACT.exe

CD "%UNINSTALL_DIR%"
RD /s /q "VATACT"

PAUSE
EXIT /B
