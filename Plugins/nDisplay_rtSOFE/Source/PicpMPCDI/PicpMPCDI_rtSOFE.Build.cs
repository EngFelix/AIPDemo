// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PicpMPCDI_rtSOFE : ModuleRules
{
	public PicpMPCDI_rtSOFE(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateIncludePaths.AddRange(
			new string[] {
				"PicpMPCDI/Private",
				"PicpProjection/Private",
				"MPCDI/Private"				
			});

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
			});

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"MPCDI",
				"PicpProjection",
				"Projects",				
				"RenderCore",
                "RHI"
			}
		);

		if (Target.bBuildEditor == true)
		{
			PrivateDependencyModuleNames.Add("UnrealEd");
		}
	}
}
