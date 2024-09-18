namespace Nuke.Common.Tools.Extension.Interfaces
{
    public interface IDownloadable
    {
        string Url { get; }
        bool Download();
    }
}
