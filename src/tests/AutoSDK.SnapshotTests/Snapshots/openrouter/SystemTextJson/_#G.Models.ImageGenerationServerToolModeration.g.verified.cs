//HintName: G.Models.ImageGenerationServerToolModeration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationServerToolModeration
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolModerationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolModeration value)
        {
            return value switch
            {
                ImageGenerationServerToolModeration.Auto => "auto",
                ImageGenerationServerToolModeration.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolModeration? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenerationServerToolModeration.Auto,
                "low" => ImageGenerationServerToolModeration.Low,
                _ => null,
            };
        }
    }
}