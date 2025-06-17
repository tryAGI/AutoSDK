//HintName: G.Models.ImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the level of detail in image processing. `"auto"` is the default and lets the system choose, `"low"` is faster but less detailed, and `"high"` preserves maximum detail. You can save tokens and speed up responses by using detail: `"low"`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageUrlDetail
    {
        /// <summary>
        /// `"low"`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// `"low"`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// `"low"`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageUrlDetail value)
        {
            return value switch
            {
                ImageUrlDetail.Auto => "auto",
                ImageUrlDetail.Low => "low",
                ImageUrlDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageUrlDetail.Auto,
                "low" => ImageUrlDetail.Low,
                "high" => ImageUrlDetail.High,
                _ => null,
            };
        }
    }
}