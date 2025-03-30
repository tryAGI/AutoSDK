//HintName: G.Models.PodcastConversationModeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of podcast to create.
    /// </summary>
    public enum PodcastConversationModeType
    {
        /// <summary>
        /// 
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PodcastConversationModeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PodcastConversationModeType value)
        {
            return value switch
            {
                PodcastConversationModeType.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PodcastConversationModeType? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => PodcastConversationModeType.Conversation,
                _ => null,
            };
        }
    }
}