using System;
using System.Diagnostics.CodeAnalysis;
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
    public class DotNetToolSettings : ToolSettings, IToolSettings
    {
        
        /// <summary>
        ///
        /// </summary>
        [ExcludeFromCodeCoverage]
        public override string ProcessToolPath => base.ProcessToolPath ?? DotNetTasks.DotNetPath;

        /// <summary>
        ///
        /// </summary>
        [ExcludeFromCodeCoverage]
        public Action<OutputType, string> ProcessCustomLogger => DotNetTasks.DotNetLogger;
        
        public DotNetToolSettings()
        {
        }

        public DotNetToolSettings(DotNetCommand command) : this()
        {
            Command = command;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual string InstallDir { get; internal set; }
        
        /// <summary>
        ///
        /// </summary>
        public DotNetCommand? Command { get; internal set; }

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
            switch (Command)
            {
                case DotNetCommand.Info:
                    arguments.Add("--info");
                    break;
                case DotNetCommand.Version:
                    arguments.Add("--version");
                    break;
                default:
                    throw new InvalidOperationException(Command.ToString());
            }
            
            return base.ConfigureProcessArguments(arguments);
        }
    }
}
