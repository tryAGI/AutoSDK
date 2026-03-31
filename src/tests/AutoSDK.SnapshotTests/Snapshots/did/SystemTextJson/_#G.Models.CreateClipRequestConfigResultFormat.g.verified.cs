//HintName: G.Models.CreateClipRequestConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    public enum CreateClipRequestConfigResultFormat
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
    public static class CreateClipRequestConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestConfigResultFormat value)
        {
            return value switch
            {
                CreateClipRequestConfigResultFormat.Mov => "mov",
                CreateClipRequestConfigResultFormat.Mp4 => "mp4",
                CreateClipRequestConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateClipRequestConfigResultFormat.Mov,
                "mp4" => CreateClipRequestConfigResultFormat.Mp4,
                "webm" => CreateClipRequestConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}