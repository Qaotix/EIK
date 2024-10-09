// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;

public class EIKShared : ModuleRules
{
	public EIKShared(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "EIKSDK" });
		Type = ModuleType.CPlusPlus;

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"EIKSDK",
				"Projects",
			}
		);
#if UE_5_0_OR_LATER && !UE_5_5_OR_LATER
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Launch",
			}
		);
#endif
	}
}
