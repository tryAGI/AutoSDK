//HintName: G.Models.ContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of message content
    /// </summary>
    public enum ContentType
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
    public static class ContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentType value)
        {
            return value switch
            {
                ContentType.Text => "text",
                ContentType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ContentType.Text,
                "image_url" => ContentType.ImageUrl,
                _ => null,
            };
        }
    }
}