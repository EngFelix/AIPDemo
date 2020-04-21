@echo off
"%ProgramFiles%\Epic Games\UE_4.25\Engine\Binaries\DotNET\UnrealBuildTool.exe" -ProjectFiles -UsePrecompiled -Game "%CD%\AIPDemo.uproject"
echo generation completed
pause