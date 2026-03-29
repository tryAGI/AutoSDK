//HintName: G.Models.GetAllChatMessagesFeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAllChatMessagesFeedbackType
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
    public static class GetAllChatMessagesFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessagesFeedbackType value)
        {
            return value switch
            {
                GetAllChatMessagesFeedbackType.ThumbsDown => "THUMBS_DOWN",
                GetAllChatMessagesFeedbackType.ThumbsUp => "THUMBS_UP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessagesFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "THUMBS_DOWN" => GetAllChatMessagesFeedbackType.ThumbsDown,
                "THUMBS_UP" => GetAllChatMessagesFeedbackType.ThumbsUp,
                _ => null,
            };
        }
    }
}