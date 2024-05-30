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

    public static class MessageContentImageUrlObjectTypeExtensions
    {
        public static string ToValueString(this MessageContentImageUrlObjectType value)
        {
            return value switch
            {
                MessageContentImageUrlObjectType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentImageUrlObjectType ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MessageContentImageUrlObjectType.ImageUrl,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentImageUrlObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageContentImageUrlObjectType.ImageUrl,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}