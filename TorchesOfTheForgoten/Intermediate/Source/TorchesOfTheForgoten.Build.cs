using UnrealBuildTool;

public class TorchesOfTheForgoten : ModuleRules
{
	public TorchesOfTheForgoten(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
