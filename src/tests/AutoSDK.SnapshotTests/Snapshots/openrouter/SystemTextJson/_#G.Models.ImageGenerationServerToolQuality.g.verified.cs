//HintName: G.Models.ImageGenerationServerToolQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationServerToolQuality
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
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolQuality value)
        {
            return value switch
            {
                ImageGenerationServerToolQuality.Auto => "auto",
                ImageGenerationServerToolQuality.High => "high",
                ImageGenerationServerToolQuality.Low => "low",
                ImageGenerationServerToolQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenerationServerToolQuality.Auto,
                "high" => ImageGenerationServerToolQuality.High,
                "low" => ImageGenerationServerToolQuality.Low,
                "medium" => ImageGenerationServerToolQuality.Medium,
                _ => null,
            };
        }
    }
}