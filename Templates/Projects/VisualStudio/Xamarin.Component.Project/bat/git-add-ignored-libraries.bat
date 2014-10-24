:: component-create.bat
@echo off
setlocal ENABLEDELAYEDEXPANSION

set GIT="%PROGRAMFILES%\Git\bin\git.exe"

dir -s .\content\lib\

%GIT% add -f .\content\lib\

%GIT% status

@IF %ERRORLEVEL% NEQ 0 PAUSE