//HintName: G.Models.MessageDeltaContentImageUrlObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image_url`.
    /// </summary>
    public enum MessageDeltaContentImageUrlObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentImageUrlObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentImageUrlObjectType value)
        {
            return value switch
            {
                MessageDeltaContentImageUrlObjectType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentImageUrlObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MessageDeltaContentImageUrlObjectType.ImageUrl,
                _ => null,
            };
        }
    }
}