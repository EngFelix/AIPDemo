// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class DisplayClusterPostprocess_rtSOFE : ModuleRules
{
	public DisplayClusterPostprocess_rtSOFE(ReadOnlyTargetRules ROTargetRules) : base(ROTargetRules)
	{
		PrivateIncludePaths.AddRange(
			new string[]
			{
				"DisplayClusterPostprocess/Private",
			}
		);

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"Engine",
			});

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"DisplayCluster",
				"OutputRemap",
				"RHI",
			}
		);

		if (Target.bBuildEditor == true)
		{
			PrivateDependencyModuleNames.Add("UnrealEd");
		}
	}
}