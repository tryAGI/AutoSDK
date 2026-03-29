//HintName: G.Models.ImageFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: CONTENT_FILTERED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTENT_FILTERED")]
        ContentFiltered,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageFinishReason value)
        {
            return value switch
            {
                ImageFinishReason.ContentFiltered => "CONTENT_FILTERED",
                ImageFinishReason.Error => "ERROR",
                ImageFinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => ImageFinishReason.ContentFiltered,
                "ERROR" => ImageFinishReason.Error,
                "SUCCESS" => ImageFinishReason.Success,
                _ => null,
            };
        }
    }
}