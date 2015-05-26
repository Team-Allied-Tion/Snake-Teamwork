using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using SoundCheck;

class Program
{
    [DllImport("WMPLib.dll")]
    static void Main()
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        wplayer.URL = "My MP3 file.mp3";
        wplayer.controls.play();
    }
}
