// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Lesson0 : ModuleRules
{
	public Lesson0(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
