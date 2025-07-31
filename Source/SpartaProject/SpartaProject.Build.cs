using UnrealBuildTool;

public class SpartaProject : ModuleRules
{
    public SpartaProject(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "EnhancedInput",
        "UMG" // UMG 모듈 추가
			}
        );

        PrivateDependencyModuleNames.AddRange(new string[] { });
    }
}