using UnrealBuildTool;

public class Assignment_3Target : TargetRules
{
	public Assignment_3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Assignment_3");
	}
}
