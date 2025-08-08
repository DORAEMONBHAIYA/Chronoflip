using UnrealBuildTool;

public class SAMPLEprojectEditorTarget : TargetRules
{
	public SAMPLEprojectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SAMPLEproject");
	}
}
