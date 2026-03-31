//HintName: G.Models.DeleteClipResponseConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    public enum DeleteClipResponseConfigResultFormat
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
    public static class DeleteClipResponseConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteClipResponseConfigResultFormat value)
        {
            return value switch
            {
                DeleteClipResponseConfigResultFormat.Mov => "mov",
                DeleteClipResponseConfigResultFormat.Mp4 => "mp4",
                DeleteClipResponseConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteClipResponseConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => DeleteClipResponseConfigResultFormat.Mov,
                "mp4" => DeleteClipResponseConfigResultFormat.Mp4,
                "webm" => DeleteClipResponseConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}