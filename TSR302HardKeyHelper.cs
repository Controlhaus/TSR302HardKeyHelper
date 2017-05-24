using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace MyNamespace
{
    public class TSR302HardKeyHelper
    {
        public Dictionary<uint, string> hardKeys = new Dictionary<uint, string>()
        {
            { 1, "power" },
            { 2, "home" },
            { 3, "menu" },
            { 4, "guide" },
            { 5, "info" },
            { 6, "volumeUp" },
            { 7, "volumeDown" },
            { 13, "channelUp" },
            { 14, "channelDown" },
            { 15, "mute" },
            { 16, "exit" },
            { 17, "last" },
            { 8, "up" },
            { 9, "down" },
            { 10, "left" },
            { 11, "right" },
            { 12, "select" },
            { 18, "play" },
            { 19, "pause" },
            { 20, "scanReverse" },
            { 21, "scanForward" },
            { 22, "skipReverse" },
            { 23, "skipForward" },
            { 24, "stop" },
            { 26, "dvr" },
            { 25, "record" },
            { 27, "numberPad1" },
            { 28, "numberPad2" },
            { 29, "numberPad3" },
            { 30, "numberPad4" },
            { 31, "numberPad5" },
            { 32, "numberPad6" },
            { 33, "numberPad7" },
            { 34, "numberPad8" },
            { 35, "numberPad9" },
            { 36, "numberPad0" },
            { 37, "clear" },
            { 38, "enter" },
            { 39, "red" },
            { 40, "green" },
            { 41, "yellow" },
            { 42, "blue" }
        };
    }
}
