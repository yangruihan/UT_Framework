// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UT_FrameworkEditor : ModuleRules
{
    public UT_FrameworkEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[]
        {
            ModuleDirectory + "/Public",
            ModuleDirectory + "/Public/Misc",
            ModuleDirectory + "/Public/Misc/Node",
            ModuleDirectory + "/Public/Sequencer",
            ModuleDirectory + "/Public/Sequencer/Track",
            ModuleDirectory + "/Public/StateMachine",
            ModuleDirectory + "/Public/StateMachine/Asset",
            ModuleDirectory + "/Public/StateMachine/Compiler",
            ModuleDirectory + "/Public/StateMachine/Debugger",
            ModuleDirectory + "/Public/StateMachine/Factory",
            ModuleDirectory + "/Public/StateMachine/Graph",
            ModuleDirectory + "/Public/StateMachine/Graph/Node",
            ModuleDirectory + "/Public/StateMachine/Graph/Node/Widget",
            ModuleDirectory + "/Public/StateMachine/Graph/Policy",
            ModuleDirectory + "/Public/StateMachine/Misc",
            ModuleDirectory + "/Public/StateMachine/Mode",
            ModuleDirectory + "/Public/StateMachine/Toolbar",
            ModuleDirectory + "/Public/Style",

            // ... add other private include paths required here ...
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
                "EditorStyle",
                "KismetWidgets",
                "UnrealEd",
                "Kismet",
                "ToolMenus",
                "GraphEditor",
                "BlueprintGraph",
                "AIModule",
                "AssetTools",
                "Projects",
                "LevelEditor",
                "KismetCompiler",
                "Paper2D",
                "Sequencer",
                "MovieScene",
                "MovieSceneTracks",
                "MovieSceneTools",
                "UT_Framework",
                // ... add private dependencies that you statically link with here ...	
            }
        );

        if (Target.bBuildDeveloperTools || (Target.Configuration != UnrealTargetConfiguration.Shipping &&
                                            Target.Configuration != UnrealTargetConfiguration.Test))
        {
            PrivateDependencyModuleNames.Add("GameplayDebugger");
            PublicDefinitions.Add("WITH_GAMEPLAY_DEBUGGER=1");
        }
        else
        {
            PublicDefinitions.Add("WITH_GAMEPLAY_DEBUGGER=0");
        }

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
                // ... add any modules that your module loads dynamically here ...
            }
        );
    }
}