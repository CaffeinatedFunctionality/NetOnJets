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
using NuGet.VisualStudio;

namespace NetOnJets.Commands
{
    public static class DefaultCommands
    {
        public static void New(string[] args)
        {
            //creates a new application
        }

        public static void Generate(string[] args)
        {
            //generates a new controller/model
        }

        public static string Help()
        {
        
            return string.Format(ConsoleFormatting.Indent(2) + "List of frequently used commands \n" +
                                 ConsoleFormatting.Indent(2) + "Create New Application - jet new APPLICATION [args] \n" +
                                 ConsoleFormatting.Indent(2) + "Generate New Model - jet new GENERATOR [args] [options]");
        }

        //for interacting with Nuget Package Manager
        public static void Install()
        {
            //
        }

        public static void Uninstall()
        {
            //uninstalls Nugets
        }

        public static void Build(string args, string buildConfiguration = "Release")
        {
            string projectFileName = args + ".sln";
            var fileInfo = new FileInfo(projectFileName);
            string projectPath = fileInfo.DirectoryName + "\\" + projectFileName;
            ProjectCollection pc = new ProjectCollection();
            Dictionary<string, string> globalProperty = new Dictionary<string, string>();
            globalProperty.Add("Configuration", buildConfiguration);

            BuildRequestData buildRequest = new BuildRequestData(projectPath, globalProperty, null, new string[] { "Rebuild" }, null);

            var buildParameter = new BuildParameters();
            buildParameter.Loggers = new List<ILogger> { new ConsoleLogger() }.AsEnumerable();

            BuildManager.DefaultBuildManager.Build(buildParameter, buildRequest);
        }
    }
}
