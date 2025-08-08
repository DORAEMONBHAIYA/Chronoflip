using UnrealBuildTool;

public class SAMPLEprojectClientTarget : TargetRules
{
	public SAMPLEprojectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SAMPLEproject");
	}
}
