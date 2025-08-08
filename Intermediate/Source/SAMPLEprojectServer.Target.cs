using UnrealBuildTool;

public class SAMPLEprojectServerTarget : TargetRules
{
	public SAMPLEprojectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SAMPLEproject");
	}
}
