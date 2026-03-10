//HintName: G.Models.ConversationFeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thumbs")]
        Thumbs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rating")]
        Rating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationFeedbackType value)
        {
            return value switch
            {
                ConversationFeedbackType.Thumbs => "thumbs",
                ConversationFeedbackType.Rating => "rating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "thumbs" => ConversationFeedbackType.Thumbs,
                "rating" => ConversationFeedbackType.Rating,
                _ => null,
            };
        }
    }
}