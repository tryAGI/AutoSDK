﻿//HintName: G.Models.SubtitleFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format of the subtitles
    /// </summary>
    public enum SubtitleFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubtitleFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubtitleFormat value)
        {
            return value switch
            {
                SubtitleFormat.Srt => "srt",
                SubtitleFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubtitleFormat? ToEnum(string value)
        {
            return value switch
            {
                "srt" => SubtitleFormat.Srt,
                "vtt" => SubtitleFormat.Vtt,
                _ => null,
            };
        }
    }
}