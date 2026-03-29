//HintName: G.Models.ChatMessageFeedbackRating.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rating for the message
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageFeedbackRating
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
    public static class ChatMessageFeedbackRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageFeedbackRating value)
        {
            return value switch
            {
                ChatMessageFeedbackRating.ThumbsDown => "THUMBS_DOWN",
                ChatMessageFeedbackRating.ThumbsUp => "THUMBS_UP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageFeedbackRating? ToEnum(string value)
        {
            return value switch
            {
                "THUMBS_DOWN" => ChatMessageFeedbackRating.ThumbsDown,
                "THUMBS_UP" => ChatMessageFeedbackRating.ThumbsUp,
                _ => null,
            };
        }
    }
}