//HintName: G.Models.CreateClipRequestConfigResultFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    public enum CreateClipRequestConfigResultFormat2
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
    public static class CreateClipRequestConfigResultFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestConfigResultFormat2 value)
        {
            return value switch
            {
                CreateClipRequestConfigResultFormat2.Mov => "mov",
                CreateClipRequestConfigResultFormat2.Mp4 => "mp4",
                CreateClipRequestConfigResultFormat2.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestConfigResultFormat2? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateClipRequestConfigResultFormat2.Mov,
                "mp4" => CreateClipRequestConfigResultFormat2.Mp4,
                "webm" => CreateClipRequestConfigResultFormat2.Webm,
                _ => null,
            };
        }
    }
}