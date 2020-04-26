@echo off
FOR %%x in (
	OptitrackNatNet
) do (
	cd %%x
	git remote rm origin
	git remote add origin https://github.com/EngFelix/%%x.git
	git config master.remote origin
	git config master.merge refs/heads/master
	git remote -v
	git pull origin master
	cd ..
)
cd ../..
FOR %%x in (

) do (
	cd %%x
	git remote rm origin
	git remote add origin https://github.com/EngFelix/%%x.git
	git config master.remote origin
	git config master.merge refs/heads/master
	git remote -v
	git pull origin master
	cd ..
)
pause