//HintName: G.Models.RemoveAllChatMessagesFeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RemoveAllChatMessagesFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THUMBS_DOWN")]
        ThumbsDown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THUMBS_UP")]
        ThumbsUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveAllChatMessagesFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAllChatMessagesFeedbackType value)
        {
            return value switch
            {
                RemoveAllChatMessagesFeedbackType.ThumbsDown => "THUMBS_DOWN",
                RemoveAllChatMessagesFeedbackType.ThumbsUp => "THUMBS_UP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAllChatMessagesFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "THUMBS_DOWN" => RemoveAllChatMessagesFeedbackType.ThumbsDown,
                "THUMBS_UP" => RemoveAllChatMessagesFeedbackType.ThumbsUp,
                _ => null,
            };
        }
    }
}