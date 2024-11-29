/*******************************************************************************
The content of this file includes portions of the proprietary AUDIOKINETIC Wwise
Technology released in source code form as part of the game integration package.
The content of this file may not be used without valid licenses to the
AUDIOKINETIC Wwise Technology.
Note that the use of the game engine is subject to the Unreal(R) Engine End User
License Agreement at https://www.unrealengine.com/en-US/eula/unreal
 
License Usage
 
Licensees holding valid licenses to the AUDIOKINETIC Wwise Technology may use
this file in accordance with the end user license agreement provided with the
software or, alternatively, in accordance with the terms contained
in a written agreement between you and Audiokinetic Inc.
Copyright (c) 2024 Audiokinetic Inc.
*******************************************************************************/

using UnrealBuildTool;

public class WwisePackaging : ModuleRules
{
	public WwisePackaging(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			
			"WwisePackagingRuntime",
		});

		PrivateDependencyModuleNames.AddRange(new string[] {
			"WwiseFileHandler",
			"WwiseResourceLoader",
			"WwiseLowLevelUtils",
		});

		if (Target.bBuildWithEditorOnlyData)
		{
			PublicDependencyModuleNames.AddRange(new string[] {
			});
			
			PrivateDependencyModuleNames.AddRange(new string[] { 
				"Engine",
				"Projects",
				"SharedSettingsWidgets",
				"SourceControl",
				"UnrealEd",
				
				"WwiseResourceCooker",
			});
		}
		else
		{
			PublicDependencyModuleNames.AddRange(new string[] {
			});
			
			PrivateDependencyModuleNames.AddRange(new string[] { 
			});
		}

#if UE_5_3_OR_LATER
		bLegacyParentIncludePaths = false;
		CppStandard = CppStandardVersion.Default;
#endif
	}
}
