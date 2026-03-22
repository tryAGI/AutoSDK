//HintName: G.Models.EmbedContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in requests
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
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
                EmbedContentType.ImageUrl => "image_url",
                EmbedContentType.Text => "text",
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
                "image_url" => EmbedContentType.ImageUrl,
                "text" => EmbedContentType.Text,
                _ => null,
            };
        }
    }
}