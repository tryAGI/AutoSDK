//HintName: G.Models.ContentChunkDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentChunkDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentChunkDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentChunkDiscriminatorType value)
        {
            return value switch
            {
                ContentChunkDiscriminatorType.ImageUrl => "image_url",
                ContentChunkDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentChunkDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ContentChunkDiscriminatorType.ImageUrl,
                "text" => ContentChunkDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}