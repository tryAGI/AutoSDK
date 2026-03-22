//HintName: G.Models.ConversationFeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        Rating,
        /// <summary>
        /// 
        /// </summary>
        Thumbs,
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
                ConversationFeedbackType.Rating => "rating",
                ConversationFeedbackType.Thumbs => "thumbs",
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
                "rating" => ConversationFeedbackType.Rating,
                "thumbs" => ConversationFeedbackType.Thumbs,
                _ => null,
            };
        }
    }
}