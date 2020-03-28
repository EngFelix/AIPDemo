@echo off
FOR %%x in (
	MegascansPlugin
	nDisplayExtensions
	rtAuralization
) do (
	cd %%x
	git remote rm origin
	git remote add origin Y:/students/Enghofer_Felix/Git/%%x.git
	git config master.remote origin
	git config master.merge refs/heads/master
	git remote -v
	git push origin master
	cd ..
)
cd ../..
FOR %%x in (
	rtSOFETemplate
	AIPDemo
) do (
	cd %%x
	git remote rm origin
	git remote add origin Y:/students/Enghofer_Felix/Git/%%x.git
	git config master.remote origin
	git config master.merge refs/heads/master
	git remote -v
	git push origin master
	cd ..
)
pause