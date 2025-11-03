// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ElUltimoBrainrot : ModuleRules
{
	public ElUltimoBrainrot(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ElUltimoBrainrot",
			"ElUltimoBrainrot/Variant_Platforming",
			"ElUltimoBrainrot/Variant_Platforming/Animation",
			"ElUltimoBrainrot/Variant_Combat",
			"ElUltimoBrainrot/Variant_Combat/AI",
			"ElUltimoBrainrot/Variant_Combat/Animation",
			"ElUltimoBrainrot/Variant_Combat/Gameplay",
			"ElUltimoBrainrot/Variant_Combat/Interfaces",
			"ElUltimoBrainrot/Variant_Combat/UI",
			"ElUltimoBrainrot/Variant_SideScrolling",
			"ElUltimoBrainrot/Variant_SideScrolling/AI",
			"ElUltimoBrainrot/Variant_SideScrolling/Gameplay",
			"ElUltimoBrainrot/Variant_SideScrolling/Interfaces",
			"ElUltimoBrainrot/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
