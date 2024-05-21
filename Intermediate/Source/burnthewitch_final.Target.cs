using UnrealBuildTool;

public class burnthewitch_finalTarget : TargetRules
{
	public burnthewitch_finalTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("burnthewitch_final");
	}
}
