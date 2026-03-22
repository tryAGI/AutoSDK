//HintName: G.Models.ImageGenToolQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The quality of the generated image. One of `low`, `medium`, `high`, <br/>
    /// or `auto`. Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ImageGenToolQuality
    {
        /// <summary>
        /// `auto`.
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
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolQuality value)
        {
            return value switch
            {
                ImageGenToolQuality.Auto => "auto",
                ImageGenToolQuality.High => "high",
                ImageGenToolQuality.Low => "low",
                ImageGenToolQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenToolQuality.Auto,
                "high" => ImageGenToolQuality.High,
                "low" => ImageGenToolQuality.Low,
                "medium" => ImageGenToolQuality.Medium,
                _ => null,
            };
        }
    }
}