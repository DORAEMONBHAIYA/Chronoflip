using UnrealBuildTool;

public class SAMPLEprojectTarget : TargetRules
{
	public SAMPLEprojectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SAMPLEproject");
	}
}
