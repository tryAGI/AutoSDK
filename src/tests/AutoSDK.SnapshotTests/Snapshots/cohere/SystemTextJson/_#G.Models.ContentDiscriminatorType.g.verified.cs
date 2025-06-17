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
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
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
                ContentDiscriminatorType.ImageUrl => "image_url",
                ContentDiscriminatorType.Text => "text",
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
                "image_url" => ContentDiscriminatorType.ImageUrl,
                "text" => ContentDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}