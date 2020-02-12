// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class DisplayClusterEditor_rtSOFE : ModuleRules
{
	public DisplayClusterEditor_rtSOFE(ReadOnlyTargetRules ROTargetRules) : base(ROTargetRules)
	{
		PrivateDependencyModuleNames.AddRange( new string[] {
			"Core",
			"CoreUObject",
			"DisplayCluster",
			"Engine",
			"UnrealEd"
		});
	}
}
