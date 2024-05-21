using UnrealBuildTool;

public class burnthewitch_finalEditorTarget : TargetRules
{
	public burnthewitch_finalEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("burnthewitch_final");
	}
}
