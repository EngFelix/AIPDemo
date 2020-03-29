@echo off
FOR %%x in (
	MegascansPlugin
	nDisplayExtensions
	rtAuralization
) do (
	cd %%x
	git status
	cd ..
)
cd ../..
FOR %%x in (
	rtSOFETemplate
	AIPDemo
) do (
	cd %%x
git status
	cd ..
)
pause