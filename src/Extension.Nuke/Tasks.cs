using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.Extension.Settings;

namespace Nuke.Common.Tools.Extension
{
    /// <summary>
    ///
    /// </summary>
    [PublicAPI]
    public static class Tasks
    {
        /// <summary>
        ///
        /// </summary>
        [ExcludeFromCodeCoverage]
        public static string DotNetPath => ToolPathResolver.TryGetEnvironmentExecutable("DOTNET_EXE") ?? ToolPathResolver.GetPathExecutable("dotnet");

        /// <summary>
        ///
        /// </summary>
        /// <param name="configurator"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<Output> DotNetTask(Configure<DotNetToolSettings> configurator)
        {
            return DotNetTask(configurator(new DotNetToolSettings()));
        }
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="toolDotNetToolSettings"></param>
        /// <returns></returns>
        public static IReadOnlyCollection<Output> DotNetTask(DotNetToolSettings toolDotNetToolSettings = null)
        {
            toolDotNetToolSettings ??= new DotNetToolSettings();
            using var process = ProcessTasks.StartProcess(toolDotNetToolSettings);
            try
            {
                process.AssertZeroExitCode();
            }
            catch (Exception e)
            {
                throw new Exception(process.Output.LastOrDefault().Text, e);
            }
            return process.Output;
        }

    }
}
