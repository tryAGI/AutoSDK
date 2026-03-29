//HintName: G.Models.ImageURLDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageURLDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
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
                ImageURLDetail.High => "high",
                ImageURLDetail.Low => "low",
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
                "high" => ImageURLDetail.High,
                "low" => ImageURLDetail.Low,
                _ => null,
            };
        }
    }
}