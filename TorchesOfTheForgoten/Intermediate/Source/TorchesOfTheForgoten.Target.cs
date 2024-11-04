using UnrealBuildTool;

public class TorchesOfTheForgotenTarget : TargetRules
{
	public TorchesOfTheForgotenTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TorchesOfTheForgoten");
	}
}
