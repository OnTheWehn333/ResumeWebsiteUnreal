// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ResumeWebsiteUnreal : ModuleRules
{
	public ResumeWebsiteUnreal(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule" });
    }
}
