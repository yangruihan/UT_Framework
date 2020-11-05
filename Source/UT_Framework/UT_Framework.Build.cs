// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UT_Framework : ModuleRules
{
    public UT_Framework(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(
            new string[]
            {
                ModuleDirectory + "/Public",
                ModuleDirectory + "/Public/Blueprint",
                ModuleDirectory + "/Public/Blueprint/StateMachine",
                ModuleDirectory + "/Public/Component",
                ModuleDirectory + "/Public/Component/LookAt",
                ModuleDirectory + "/Public/Component/Pool",
                ModuleDirectory + "/Public/Component/StateMachine",
                ModuleDirectory + "/Public/Library",
                ModuleDirectory + "/Public/Manager",
                ModuleDirectory + "/Public/Manager/Pool",
                ModuleDirectory + "/Public/Object",
                ModuleDirectory + "/Public/Object/LoadSystem",
                ModuleDirectory + "/Public/Object/Pool",
                ModuleDirectory + "/Public/Object/StateMachine",
                ModuleDirectory + "/Public/Object/StateMachine/State",
                ModuleDirectory + "/Public/Object/StateMachine/Transition",
                ModuleDirectory + "/Public/Sequencer",
                ModuleDirectory + "/Public/Sequencer/Evaluation",
                ModuleDirectory + "/Public/Sequencer/Section",
                ModuleDirectory + "/Public/Sequencer/Track",
                ModuleDirectory + "/Public/Utility",
                ModuleDirectory + "/Public/Widget",
                ModuleDirectory + "/Public/Widget/Component",
                ModuleDirectory + "/Public/Widget/Navigation",
            });

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                // ... add other public dependencies that you statically link with here ...
            }
        );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "InputCore",
                "Engine",
                "Slate",
                "SlateCore",
                "UMG",
                "AIModule",
                "Paper2D",
                "MovieScene",
                "MovieSceneTracks",
                "GameplayTasks",
                // ... add private dependencies that you statically link with here ...	
            }
        );


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
                // ... add any modules that your module loads dynamically here ...
            }
        );
    }
}