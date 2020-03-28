@echo off
FOR %%x in (
	MegascansPlugin
	nDisplayExtensions
	rtAuralization
	rtSOFETemplate
	AIPDemo
) do (
	cd %%x
	git remote -v
	cd ..
)
pause
