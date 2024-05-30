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

    public static class MessageDeltaContentImageUrlObjectTypeExtensions
    {
        public static string ToValueString(this MessageDeltaContentImageUrlObjectType value)
        {
            return value switch
            {
                MessageDeltaContentImageUrlObjectType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentImageUrlObjectType ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MessageDeltaContentImageUrlObjectType.ImageUrl,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentImageUrlObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaContentImageUrlObjectType.ImageUrl,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}