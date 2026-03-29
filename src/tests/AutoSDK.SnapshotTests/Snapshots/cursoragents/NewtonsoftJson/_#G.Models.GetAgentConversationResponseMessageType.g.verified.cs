//HintName: G.Models.GetAgentConversationResponseMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of message - either from the user or the model<br/>
    /// Example: user_message
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAgentConversationResponseMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant_message")]
        AssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_message")]
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentConversationResponseMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentConversationResponseMessageType value)
        {
            return value switch
            {
                GetAgentConversationResponseMessageType.AssistantMessage => "assistant_message",
                GetAgentConversationResponseMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentConversationResponseMessageType? ToEnum(string value)
        {
            return value switch
            {
                "assistant_message" => GetAgentConversationResponseMessageType.AssistantMessage,
                "user_message" => GetAgentConversationResponseMessageType.UserMessage,
                _ => null,
            };
        }
    }
}