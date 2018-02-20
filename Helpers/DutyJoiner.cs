using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Windows.Media;
using ff14bot.Helpers;
using ff14bot.RemoteWindows;
using Mud.Settings;

namespace Mud.Helpers
{
    // Part of the code below is taken from DFAlert,
    // obviously the credit for this goes all to Parrot.
    // Thank him before me, he deserve it ;)
    // DFAlert Plugin Page: https://www.thebuddyforum.com/threads/plugin-dfalert-a-queue-monitor-for-the-duty-finder.174670/
    internal static class DutyJoiner
    {
        private static DateTime _joinTime;
        private static bool _isTimeSet, _commenced;

        public static void Commence()
        {
            if (!_isTimeSet)
            {
                _joinTime = DateTime.Now.Add(TimeSpan.FromSeconds(MudSettings.Instance.AutoCommenceDutyDelay));
                _isTimeSet = true;
            }

            if (_commenced || DateTime.Now <= _joinTime || !ContentsFinderConfirm.IsOpen) return;
            ContentsFinderConfirm.Commence();
            _commenced = true;
        }

        public static void Reset()
        {
            _commenced = false;
            _isTimeSet = false;
        }
    }

    internal static class SndPlayer
    {
        private const string FileName = "DungeonIsReady";
        private static readonly string SoundPath = Application.StartupPath + @"\BotBases\MudAssist\Sound\";

        private static readonly IEnumerable<string> SupportedExtension = Directory
            .EnumerateFiles(SoundPath, "*.*", SearchOption.AllDirectories).Where(s =>
                s.EndsWith(".wma", StringComparison.OrdinalIgnoreCase) ||
                s.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase) ||
                s.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase) ||
                s.EndsWith(".m4a", StringComparison.OrdinalIgnoreCase) ||
                s.EndsWith(".ogg", StringComparison.OrdinalIgnoreCase));

        public static void Play()
        {
            var supportedExtension = SupportedExtension;
            if (supportedExtension == null) return;
            try
            {
                var sp = new SoundPlayer
                {
                    SoundLocation = SoundPath + FileName + SupportedExtension.First()
                };
                sp.Play();
            }
            catch (Exception ex)
            {
                Logging.Write(Colors.Red, $@"Could not play audio: {ex.Message}");
            }
        }
    }
}