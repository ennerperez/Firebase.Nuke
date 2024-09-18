using System;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.Extension.Commands;
using Nuke.Common.Tools.Extension.Settings;

// ReSharper disable PossibleNullReferenceException

namespace Nuke.Common.Tools.Extension
{
    /// <summary>
    ///
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static class Extensions
    {
        #region Verbose

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <param name="verbose"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T SetVerbose<T>(this T toolSettings, bool? verbose) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T ResetVerbose<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T EnableVerbose<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = true;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T DisableVerbose<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = false;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T ToggleVerbose<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = !toolSettings.Verbose;
            return toolSettings;
        }

        #endregion

        #region Force

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <param name="force"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T SetForce<T>(this T toolSettings, bool? force) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T ResetForce<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T EnableForce<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = true;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T DisableForce<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = false;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T ToggleForce<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = !toolSettings.Force;
            return toolSettings;
        }

        #endregion

        #region OutputDir

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <param name="outputDir"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T SetOutputDir<T>(this T toolSettings, string outputDir) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDir = outputDir;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T ResetOutputDir<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDir = null;
            return toolSettings;
        }

        #endregion

        #region Output

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <param name="output"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T SetOutput<T>(this T toolSettings, string output) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="InvalidCastException"></exception>
        [Pure]
        public static T ResetOutput<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }

        #endregion

        #region Command

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <param name="command"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T SetCommand<T>(this T toolSettings, DotNetCommand command) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Command = command;
            return toolSettings;
        }

        #endregion

        #region DryRun

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <param name="dryRun"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T SetDryRun<T>(this T toolSettings, bool? dryRun) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = dryRun;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T ResetDryRun<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = null;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T EnableDryRun<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = true;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T DisableDryRun<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = false;
            return toolSettings;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="toolSettings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Pure]
        public static T ToggleDryRun<T>(this T toolSettings) where T : DotNetToolSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DryRun = !toolSettings.DryRun;
            return toolSettings;
        }

        #endregion
    }
}
