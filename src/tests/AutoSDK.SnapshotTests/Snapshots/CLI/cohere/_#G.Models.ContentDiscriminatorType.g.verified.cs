//HintName: G.Models.ContentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentDiscriminatorType
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
    public static class ContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentDiscriminatorType value)
        {
            return value switch
            {
                ContentDiscriminatorType.Text => "text",
                ContentDiscriminatorType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ContentDiscriminatorType.Text,
                "image_url" => ContentDiscriminatorType.ImageUrl,
                _ => null,
            };
        }
    }
}