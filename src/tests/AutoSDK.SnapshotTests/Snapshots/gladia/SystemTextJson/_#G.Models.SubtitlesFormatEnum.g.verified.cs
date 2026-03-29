//HintName: G.Models.SubtitlesFormatEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Subtitles formats you want your transcription to be formatted to
    /// </summary>
    public enum SubtitlesFormatEnum
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
    public static class SubtitlesFormatEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubtitlesFormatEnum value)
        {
            return value switch
            {
                SubtitlesFormatEnum.Srt => "srt",
                SubtitlesFormatEnum.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubtitlesFormatEnum? ToEnum(string value)
        {
            return value switch
            {
                "srt" => SubtitlesFormatEnum.Srt,
                "vtt" => SubtitlesFormatEnum.Vtt,
                _ => null,
            };
        }
    }
}