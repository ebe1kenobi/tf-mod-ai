@echo off

echo ================================
echo =       BUILD RELEASE          =
echo ================================

< NUL call config.bat

echo %RELEASE_PATH%

rmdir /S /Q %RELEASE_PATH%
mkdir %RELEASE_PATH%

copy "%BUILD_PATH%%PDB_FILE_NAME%" %RELEASE_PATH%
copy "%BUILD_PATH%CommandLine.dll" %RELEASE_PATH%
copy "%BUILD_PATH%Microsoft.Threading.Tasks.dll" %RELEASE_PATH%
copy "%BUILD_PATH%Microsoft.Threading.Tasks.Extensions.Desktop.dll" %RELEASE_PATH%
copy "%BUILD_PATH%Microsoft.Threading.Tasks.Extensions.dll" %RELEASE_PATH%
copy "%BUILD_PATH%Mono.Cecil.dll" %RELEASE_PATH%
copy "%BUILD_PATH%Newtonsoft.Json.dll" %RELEASE_PATH%
copy "%BUILD_PATH%%PATCHERLIB_DLL%" %RELEASE_PATH%
copy "%BUILD_PATH%System.IO.dll" %RELEASE_PATH%
copy "%BUILD_PATH%System.Runtime.dll" %RELEASE_PATH%
copy "%BUILD_PATH%System.Threading.Tasks.dll" %RELEASE_PATH%
copy "%BUILD_PATH%%DLL_FILE_NAME%" %RELEASE_PATH%
copy "%BUILD_PATH%%PATCHER_EXE%" %RELEASE_PATH%
copy "%BUILD_PATH%Mono.Cecil.dll" %RELEASE_PATH%

xcopy /E /I %REPO_PATH%ModFile\* %RELEASE_PATH%


pause
