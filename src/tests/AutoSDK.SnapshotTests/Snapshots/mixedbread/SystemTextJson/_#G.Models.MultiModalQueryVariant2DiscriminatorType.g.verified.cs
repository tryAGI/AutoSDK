//HintName: G.Models.MultiModalQueryVariant2DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MultiModalQueryVariant2DiscriminatorType
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
    public static class MultiModalQueryVariant2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiModalQueryVariant2DiscriminatorType value)
        {
            return value switch
            {
                MultiModalQueryVariant2DiscriminatorType.ImageUrl => "image_url",
                MultiModalQueryVariant2DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiModalQueryVariant2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MultiModalQueryVariant2DiscriminatorType.ImageUrl,
                "text" => MultiModalQueryVariant2DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}