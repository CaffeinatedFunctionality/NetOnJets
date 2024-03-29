﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
using PowerArgs;

namespace NetOnJets.Models
{
    class CommandArgs
    {

        [HelpHook, ArgShortcut("-?"), ArgDescription("Shows this help")]
        public bool Help { get; set; }

        [ArgActionMethod, ArgDescription("Creates a new application")]
        public void New(NewArgs args)
        {
            //creates a new application
        }

        [ArgActionMethod, ArgDescription("Generates a model with attributes or controller with views")]
        [ArgShortcut("g"), ArgShortcut("gen")]
        public void Generate(GeneratorArgs args)
        {
            if (args.Model == true)
            {
                //run model generator
            }
            else if (args.Controller == true)
            {
                //run controller generator
            }
        }

        [ArgActionMethod, ArgDescription("Installs Nuget Package")]
        //for interacting with Nuget Package Manager
        public void Install()
        {
            //installs Nugets
        }

        [ArgActionMethod, ArgDescription("Uninstalls Nuget Package")]
        public void Uninstall()
        {
            //uninstalls Nugets
        }

        [ArgActionMethod, ArgDescription("Builds a project or solution")]
        public void Build(BuildArgs args)
        {
            string projectFileName;
            var projregex = new Regex(@".*\.csproj?$");
            var slnregex = new Regex(@".*\.sln?$");
            if (projregex.IsMatch(args.SolutionName) || slnregex.IsMatch(args.SolutionName))
            {
                projectFileName = args.SolutionName;
            }
            else
            {
                if (args.Project == true)
                {
                    projectFileName = args.SolutionName + ".csproj";
                }
                else
                {
                    projectFileName = args.SolutionName + ".sln";
                }
            }
            var fileInfo = new FileInfo(projectFileName);
            string projectPath = fileInfo.DirectoryName + "\\" + projectFileName;
            ProjectCollection pc = new ProjectCollection();
            Dictionary<string, string> globalProperty = new Dictionary<string, string>();
            globalProperty.Add("Configuration", args.BuildConfiguration);

            BuildRequestData buildRequest = new BuildRequestData(projectPath, globalProperty, null, new string[] { "Rebuild" }, null);

            var buildParameter = new BuildParameters();
            buildParameter.Loggers = new List<ILogger> { new ConsoleLogger() }.AsEnumerable();

            BuildManager.DefaultBuildManager.Build(buildParameter, buildRequest);
        }
    }
}
