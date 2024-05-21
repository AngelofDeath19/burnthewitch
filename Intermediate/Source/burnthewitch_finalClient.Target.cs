using UnrealBuildTool;

public class burnthewitch_finalClientTarget : TargetRules
{
	public burnthewitch_finalClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("burnthewitch_final");
	}
}
