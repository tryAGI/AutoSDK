//HintName: G.Models.EmbedContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in requests
    /// </summary>
    public enum EmbedContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedContentType value)
        {
            return value switch
            {
                EmbedContentType.Text => "text",
                EmbedContentType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedContentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => EmbedContentType.Text,
                "image_url" => EmbedContentType.ImageUrl,
                _ => null,
            };
        }
    }
}