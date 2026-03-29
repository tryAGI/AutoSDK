//HintName: G.Models.ImageGenerationServerToolSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationServerToolSize
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1536,
        /// <summary>
        /// 
        /// </summary>
        x1536x1024,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolSize value)
        {
            return value switch
            {
                ImageGenerationServerToolSize.x1024x1024 => "1024x1024",
                ImageGenerationServerToolSize.x1024x1536 => "1024x1536",
                ImageGenerationServerToolSize.x1536x1024 => "1536x1024",
                ImageGenerationServerToolSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageGenerationServerToolSize.x1024x1024,
                "1024x1536" => ImageGenerationServerToolSize.x1024x1536,
                "1536x1024" => ImageGenerationServerToolSize.x1536x1024,
                "auto" => ImageGenerationServerToolSize.Auto,
                _ => null,
            };
        }
    }
}