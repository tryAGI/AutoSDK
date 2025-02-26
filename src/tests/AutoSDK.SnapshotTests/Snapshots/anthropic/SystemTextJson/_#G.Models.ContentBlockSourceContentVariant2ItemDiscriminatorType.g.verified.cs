//HintName: G.Models.ContentBlockSourceContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentBlockSourceContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockSourceContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockSourceContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockSourceContentVariant2ItemDiscriminatorType.Image => "image",
                ContentBlockSourceContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockSourceContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ContentBlockSourceContentVariant2ItemDiscriminatorType.Image,
                "text" => ContentBlockSourceContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}