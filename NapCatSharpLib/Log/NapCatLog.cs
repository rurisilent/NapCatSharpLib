using System;
using System.Collections.Generic;
using System.Text;

namespace NapCatSharpLib.Log
{
    public enum NapCatLogType
    {
        normal,
        warning,
        error
    }

    public delegate void EvtNapCatLog(string content, NapCatLogType type);
}
