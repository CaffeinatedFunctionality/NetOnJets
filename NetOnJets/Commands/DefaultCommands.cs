using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
using NetOnJets.Models;
using NuGet.VisualStudio;
using PowerArgs;

namespace NetOnJets.Commands
{
    public static class DefaultCommands
    {
        [HelpHook, ArgShortcut("-?"), ArgDescription("Shows this help")]
        public static bool Help { get; set; }

        [ArgActionMethod, ArgDescription("Creates a new application")]
        public static void New(NewArgs args)
        {
            //creates a new application
        }

        [ArgActionMethod, ArgDescription("Generates a model with attributes or controller with views")]
        public static void Generate(GeneratorArgs args)
        {
            //generates a new controller/model
        }

        [ArgActionMethod, ArgDescription("Installs Nuget Package")]
        //for interacting with Nuget Package Manager
        public static void Install()
        {
            //installs Nugets
        }

        [ArgActionMethod, ArgDescription("Uninstalls Nuget Package")]
        public static void Uninstall()
        {
            //uninstalls Nugets
        }

        [ArgActionMethod, ArgDescription("Builds a solution")]
        public static void Build(BuildArgs args)
        {
            string projectFileName = args.SolutionName + ".sln";
            var fileInfo = new FileInfo(projectFileName);
            string projectPath = fileInfo.DirectoryName + "\\" + projectFileName;
            ProjectCollection pc = new ProjectCollection();
            Dictionary<string, string> globalProperty = new Dictionary<string, string>();
            globalProperty.Add("Configuration", args.ConfigurationName);

            BuildRequestData buildRequest = new BuildRequestData(projectPath, globalProperty, null, new string[] { "Rebuild" }, null);

            var buildParameter = new BuildParameters();
            buildParameter.Loggers = new List<ILogger> { new ConsoleLogger() }.AsEnumerable();

            BuildManager.DefaultBuildManager.Build(buildParameter, buildRequest);
        }
    }
}
