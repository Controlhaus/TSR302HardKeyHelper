using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace MyNamespace
{
    public static class TSR302HardKeyHelper
    {
        public enum HardKeys
        {
             power = 1,
             home = 2,
             menu = 3,
             guide =4 ,
             info = 5,
             volumeUp = 6,
             volumeDown = 7,
             channelUp = 13,
             channelDown = 14,
             mute = 15,
             exit = 16,
             last = 17,
             up = 8,
             down = 9,
             left = 10,
             right = 11,
             select = 12,
             play = 18,
             pause = 19,
             scanReverse = 20,
             scanForward = 21,
             skipReverse = 22,
             skipForward = 23,
             stop = 24,
             dvr = 26,
             record = 25,
             numberPad1 = 27,
             numberPad2 = 28,
             numberPad3 = 29,
             numberPad4 = 30,
             numberPad5 = 31,
             numberPad6 = 32,
             numberPad7 = 33,
             numberPad8 = 34,
             numberPad9 = 35,
             numberPad0 = 36,
             clear = 37,
             enter = 38,
             red = 39,
             green = 40,
             yellow = 41,
             blue = 42
        };

        public static bool IsDefined(string name)
        {
            return Enum.IsDefined(typeof(HardKeys), name);
        }

        public static bool IsDefined(HardKeys value)
        {
            return Enum.IsDefined(typeof(HardKeys), value);
        }        
    }
}
