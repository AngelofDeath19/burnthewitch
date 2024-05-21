using UnrealBuildTool;

public class burnthewitch_finalServerTarget : TargetRules
{
	public burnthewitch_finalServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("burnthewitch_final");
	}
}
