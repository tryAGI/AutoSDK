﻿//HintName: G.Models.GlobalEmoteThemeModeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GlobalEmoteThemeModeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Dark,
        /// <summary>
        /// 
        /// </summary>
        Light,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlobalEmoteThemeModeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalEmoteThemeModeItem value)
        {
            return value switch
            {
                GlobalEmoteThemeModeItem.Dark => "dark",
                GlobalEmoteThemeModeItem.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalEmoteThemeModeItem? ToEnum(string value)
        {
            return value switch
            {
                "dark" => GlobalEmoteThemeModeItem.Dark,
                "light" => GlobalEmoteThemeModeItem.Light,
                _ => null,
            };
        }
    }
}