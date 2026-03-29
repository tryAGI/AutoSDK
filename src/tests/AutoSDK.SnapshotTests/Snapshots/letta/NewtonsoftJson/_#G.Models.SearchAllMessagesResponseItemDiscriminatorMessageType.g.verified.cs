//HintName: G.Models.SearchAllMessagesResponseItemDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchAllMessagesResponseItemDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant_message")]
        AssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning_message")]
        ReasoningMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system_message")]
        SystemMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_message")]
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