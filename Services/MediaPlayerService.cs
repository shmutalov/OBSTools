using System.Diagnostics;

namespace OBSTools.Services
{
    public class MediaPlayerService : IMediaPlayerService
    {
        public string GetCurrentSong()
        {
            var procs = Process.GetProcessesByName("mpc-hc64").FirstOrDefault();
            var songName = procs?.MainWindowTitle ?? "";
            return Path.GetFileNameWithoutExtension(songName);
        }
    }
}
