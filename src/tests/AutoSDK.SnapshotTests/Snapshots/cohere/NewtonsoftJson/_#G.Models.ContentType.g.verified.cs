//HintName: G.Models.ContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of message content
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentType
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
    public static class ContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentType value)
        {
            return value switch
            {
                ContentType.ImageUrl => "image_url",
                ContentType.Text => "text",
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
                "image_url" => ContentType.ImageUrl,
                "text" => ContentType.Text,
                _ => null,
            };
        }
    }
}