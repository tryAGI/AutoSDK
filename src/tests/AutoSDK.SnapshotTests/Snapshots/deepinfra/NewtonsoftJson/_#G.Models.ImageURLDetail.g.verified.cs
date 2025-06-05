//HintName: G.Models.ImageURLDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageURLDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageURLDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageURLDetail value)
        {
            return value switch
            {
                ImageURLDetail.Auto => "auto",
                ImageURLDetail.Low => "low",
                ImageURLDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageURLDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageURLDetail.Auto,
                "low" => ImageURLDetail.Low,
                "high" => ImageURLDetail.High,
                _ => null,
            };
        }
    }
}