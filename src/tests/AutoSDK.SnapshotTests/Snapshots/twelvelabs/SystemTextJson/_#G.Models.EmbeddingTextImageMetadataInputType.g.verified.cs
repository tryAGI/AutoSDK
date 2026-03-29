//HintName: G.Models.EmbeddingTextImageMetadataInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingTextImageMetadataInputType
    {
        /// <summary>
        /// 
        /// </summary>
        TextImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingTextImageMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingTextImageMetadataInputType value)
        {
            return value switch
            {
                EmbeddingTextImageMetadataInputType.TextImage => "text_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingTextImageMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "text_image" => EmbeddingTextImageMetadataInputType.TextImage,
                _ => null,
            };
        }
    }
}