/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Howaajin. All rights reserved.
 *  Licensed under the MIT License. See License in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace UnrealBuildTool.Rules
{
	using System.IO;

	public class GraphFormatter : ModuleRules
	{
		public GraphFormatter(ReadOnlyTargetRules Target) : base(Target)
		{
			PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
			PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
			PublicIncludePaths.AddRange(
				new string[] 
				{ 
					"../Plugins/Experimental/ControlRig/Source/ControlRig/Public",
					"../Plugins/Experimental/ControlRig/Source/ControlRigEditor/Public",
					"../Plugins/Experimental/ControlRig/Source/ControlRigDeveloper/Public"
					
				});
			PrivateIncludePaths.Add("../Plugins/Experimental/ControlRig/Source/ControlRig/Private/Units");
			PrivateIncludePaths.Add("../Plugins/Experimental/ControlRig/Source/ControlRig/Private");
			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"ApplicationCore",
					"InputCore",
					"Engine",
					"Kismet",
					"UnrealEd",
					"SlateCore",
					"Slate",
					"EditorStyle",
					"GraphEditor",
					"BlueprintGraph",
					"MaterialEditor",
					"Projects",
					"AIModule",
					"AIGraph",
					"BehaviorTreeEditor",
					"ControlRig",
					"ControlRigEditor",
					"ControlRigDeveloper",
                    "AnimGraphRuntime",
                    "MovieScene",
                    "MovieSceneTracks",
                    "PropertyPath",
					"TimeManagement",
					"DeveloperSettings",
					"RigVMDeveloper",
				}
			);
		}
	}
}
