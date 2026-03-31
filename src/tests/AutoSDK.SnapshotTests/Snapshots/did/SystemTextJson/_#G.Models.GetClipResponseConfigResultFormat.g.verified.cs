//HintName: G.Models.GetClipResponseConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    public enum GetClipResponseConfigResultFormat
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
    public static class GetClipResponseConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipResponseConfigResultFormat value)
        {
            return value switch
            {
                GetClipResponseConfigResultFormat.Mov => "mov",
                GetClipResponseConfigResultFormat.Mp4 => "mp4",
                GetClipResponseConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipResponseConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetClipResponseConfigResultFormat.Mov,
                "mp4" => GetClipResponseConfigResultFormat.Mp4,
                "webm" => GetClipResponseConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}