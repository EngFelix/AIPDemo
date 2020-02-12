// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class DisplayClusterMessageInterception_rtSOFE : ModuleRules
{
	public DisplayClusterMessageInterception_rtSOFE(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"DisplayCluster",
				"Engine",
				"Messaging",
			});
	}
}
