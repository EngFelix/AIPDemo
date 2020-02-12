// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class DisplayClusterInput_rtSOFE : ModuleRules
{
	public DisplayClusterInput_rtSOFE(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateIncludePathModuleNames.AddRange(
			new string[]
			{
				"InputDevice",
				"HeadMountedDisplay",
				"DisplayCluster_rtSOFE"
			}
		);

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"InputCore",
				"InputDevice"
			});

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"ApplicationCore",
				"Core",
				"CoreUObject",
				"DisplayCluster",
				"Engine",
				"InputCore",
				"InputDevice",
				"HeadMountedDisplay"
			}
		);

		PrivateIncludePaths.AddRange(
			new string[] {
				"DisplayClusterInput/Private",
				"DisplayCluster/Private",
			}
		);
	}
}
