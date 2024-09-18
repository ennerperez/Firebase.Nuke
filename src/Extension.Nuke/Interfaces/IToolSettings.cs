namespace Nuke.Common.Tools.Extension.Interfaces
{
    public interface IToolSettings
    {
        bool? Force { get; }

        bool? DryRun { get; }

        bool? Verbose { get; }

        string OutputDir { get; }

        string Output { get; }

        bool Elevated { get; }
    }
}
