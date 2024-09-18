using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using JetBrains.Annotations;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Extension.Commands;
using Nuke.Common.Tools.Extension.Interfaces;

namespace Nuke.Common.Tools.Extension.Settings
{
    /// <summary>
    ///
    /// </summary>
    [PublicAPI]
    [Serializable]
    public class CmdSettings : ToolSettings, IToolSettings
    {
        
        /// <summary>
        ///
        /// </summary>
        [ExcludeFromCodeCoverage]
        public override string ProcessToolPath => Path.Combine(InstallDir, Executable);

        /// <summary>
        ///
        /// </summary>
        [ExcludeFromCodeCoverage]
        public Action<OutputType, string> ProcessCustomLogger => DotNetTasks.DotNetLogger;

        public CmdSettings()
        {
            
        }
        
        public CmdSettings(string executable): this()
        {
            Executable = executable;
        }
        
        public CmdSettings(string executable, CmdCommand command): this()
        {
            Executable = executable;
            Command = command;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual string InstallDir { get; internal set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Executable { get; private set; }

        /// <summary>
        ///
        /// </summary>
        public CmdCommand Command { get; internal set; }

        /// <summary>
        ///
        /// </summary>
        public bool? Force { get; internal set; }

        /// <summary>
        ///
        /// </summary>
        public bool? DryRun { get; internal set; }

        /// <summary>
        ///
        /// </summary>
        public virtual bool? Verbose { get; internal set; }

        /// <summary>
        ///
        /// </summary>
        public string OutputDir { get; internal set; }

        /// <summary>
        ///
        /// </summary>
        public string Output { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Elevated { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="arguments"></param>
        /// <returns></returns>
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
                .Add("--verbose", Verbose)
                .Add("--Output {value}", Output)
                .Add("--OutputDir {value}", OutputDir);
            
            return base.ConfigureProcessArguments(arguments);
        }
    }
}
