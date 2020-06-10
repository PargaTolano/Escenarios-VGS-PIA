using UnrealBuildTool;

public class PIA_EscenariosTarget : TargetRules
{
	public PIA_EscenariosTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PIA_Escenarios");
	}
}
