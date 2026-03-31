//HintName: G.Models.ClipConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    public enum ClipConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipConfigResultFormat value)
        {
            return value switch
            {
                ClipConfigResultFormat.Mov => "mov",
                ClipConfigResultFormat.Mp4 => "mp4",
                ClipConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => ClipConfigResultFormat.Mov,
                "mp4" => ClipConfigResultFormat.Mp4,
                "webm" => ClipConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}