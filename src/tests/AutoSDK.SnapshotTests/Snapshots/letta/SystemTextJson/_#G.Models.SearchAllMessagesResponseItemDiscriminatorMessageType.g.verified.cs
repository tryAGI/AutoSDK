//HintName: G.Models.SearchAllMessagesResponseItemDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchAllMessagesResponseItemDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        ReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        SystemMessage,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchAllMessagesResponseItemDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchAllMessagesResponseItemDiscriminatorMessageType value)
        {
            return value switch
            {
                SearchAllMessagesResponseItemDiscriminatorMessageType.AssistantMessage => "assistant_message",
                SearchAllMessagesResponseItemDiscriminatorMessageType.ReasoningMessage => "reasoning_message",
                SearchAllMessagesResponseItemDiscriminatorMessageType.SystemMessage => "system_message",
                SearchAllMessagesResponseItemDiscriminatorMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchAllMessagesResponseItemDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "assistant_message" => SearchAllMessagesResponseItemDiscriminatorMessageType.AssistantMessage,
                "reasoning_message" => SearchAllMessagesResponseItemDiscriminatorMessageType.ReasoningMessage,
                "system_message" => SearchAllMessagesResponseItemDiscriminatorMessageType.SystemMessage,
                "user_message" => SearchAllMessagesResponseItemDiscriminatorMessageType.UserMessage,
                _ => null,
            };
        }
    }
}