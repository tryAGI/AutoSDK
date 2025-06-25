//HintName: G.Models.EmbedContentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbedContentDiscriminatorType
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
    public static class EmbedContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedContentDiscriminatorType value)
        {
            return value switch
            {
                EmbedContentDiscriminatorType.ImageUrl => "image_url",
                EmbedContentDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => EmbedContentDiscriminatorType.ImageUrl,
                "text" => EmbedContentDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}