//HintName: G.Models.ContentPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content part.
    /// </summary>
    public enum ContentPartType
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
    public static class ContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartType value)
        {
            return value switch
            {
                ContentPartType.ImageUrl => "image_url",
                ContentPartType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ContentPartType.ImageUrl,
                "text" => ContentPartType.Text,
                _ => null,
            };
        }
    }
}