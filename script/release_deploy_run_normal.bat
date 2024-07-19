@echo OFF
< NUL call config.bat

cd %SCRIPT_PATH%
%REPO_DRIVE%
< NUL call release.bat

cd %SCRIPT_PATH%
%REPO_DRIVE%
< NUL call deploy.bat

echo =================================
echo =       EXECUTE TOWERFALL       =
echo =================================

%TOWERFALL_EXE_PATH%

pause
