//HintName: G.Models.MessageContentImageUrlObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentImageUrlObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentImageUrlObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentImageUrlObjectType value)
        {
            return value switch
            {
                MessageContentImageUrlObjectType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentImageUrlObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MessageContentImageUrlObjectType.ImageUrl,
                _ => null,
            };
        }
    }
}