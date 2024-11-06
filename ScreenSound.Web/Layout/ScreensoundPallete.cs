﻿using MudBlazor;
using MudBlazor.Utilities;

namespace ScreenSound.Web.Layout;

public class ScreensoundPalette : PaletteDark
{
    private ScreensoundPalette()
    {
        Primary = new MudColor("#9966FF");
        Secondary = new MudColor("#F6AD31");
        Tertiary = new MudColor("8AE491");
    }

    public static ScreensoundPalette CreatePallete => new();
}
