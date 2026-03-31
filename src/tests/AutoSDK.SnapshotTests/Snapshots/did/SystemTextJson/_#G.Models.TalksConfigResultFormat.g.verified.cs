//HintName: G.Models.TalksConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    public enum TalksConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TalksConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TalksConfigResultFormat value)
        {
            return value switch
            {
                TalksConfigResultFormat.Mov => "mov",
                TalksConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TalksConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => TalksConfigResultFormat.Mov,
                "mp4" => TalksConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}