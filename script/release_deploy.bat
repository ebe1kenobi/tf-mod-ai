@echo OFF
< NUL call config.bat

cd %SCRIPT_PATH%
%REPO_DRIVE%
< NUL call release.bat

cd %SCRIPT_PATH%
%REPO_DRIVE%
< NUL call deploy.bat

pause
