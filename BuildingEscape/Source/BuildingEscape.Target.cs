// Copyright © Hysan. All Rights Reserved.


using UnrealBuildTool;
using System.Collections.Generic;

public class BuildingEscapeTarget : TargetRules
{
	public BuildingEscapeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "BuildingEscape" } );
	}
}
