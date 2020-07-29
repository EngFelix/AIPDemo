### AIPDemo
This is UE4 demo is created by Felix Enghofer for the purpose of presenting the newly created rtSOFE integration plugins 
during the master's thesis "Development and Implementation of a Framework for creating and controlling audio-visual Scenes" by
Felix Enghofer M.Sc., Lubos Hladek PhD, Prof. Dr.-Ing Bernhard U. Seeber.

## Clone this repository
To clone this repository, execute the following commands in a cmd window at the location where the repository should be cloned: 
```
git clone --recurse-submodules -j8 https://github.com/EngFelix/AIPDemo
cd aipdemo
git submodule foreach "git checkout master"
```
If you do not have access to the `OptiTrackNatNet` and `MegascansPlugin` repositories, simply clone this repo and the
`rtAuralization` and `nDisplayExtensions` repos in the `/Plugins` folder and copy the other plugins from their websites
```
git clone https://github.com/EngFelix/AIPDemo
cd aipdemo/plugins
git clone https://github.com/EngFelix/rtAuralization
git clone https://github.com/EngFelix/nDisplayExtensions
```

## Submodules
The plugins `rtAuralization` and `nDisplayExtensions` are the core rtSOFE integration plugins. They are stored in
separate git repositories and are linked here in the `/Plugins` directory. The `OptiTrackNatNet` and `MegascansPlugin` 
plugins can be downloaded from the respective websites.

When changing something in the plugins, the changes of the plugin's git repository need to be committed as well as pushed.
```
cd Plugins/rtAuralization
git add .
git commit -m "changed files"
git push
```
Subsequently, the `AIPDemo` repository needs to use the new commit of the `rtAuralization` plugin. Executing 
`git status` will show, that there are new commits (changes) in the plugin. 
```
cd ../..
git add .
git commit -m "updated rtAuralization"
git push
```
