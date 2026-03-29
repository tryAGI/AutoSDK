//HintName: G.Models.ChatAgentRequestWebhookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatAgentRequestWebhookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat_analyzed")]
        ChatAnalyzed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat_ended")]
        ChatEnded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat_started")]
        ChatStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatAgentRequestWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAgentRequestWebhookEvent value)
        {
            return value switch
            {
                ChatAgentRequestWebhookEvent.ChatAnalyzed => "chat_analyzed",
                ChatAgentRequestWebhookEvent.ChatEnded => "chat_ended",
                ChatAgentRequestWebhookEvent.ChatStarted => "chat_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAgentRequestWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "chat_analyzed" => ChatAgentRequestWebhookEvent.ChatAnalyzed,
                "chat_ended" => ChatAgentRequestWebhookEvent.ChatEnded,
                "chat_started" => ChatAgentRequestWebhookEvent.ChatStarted,
                _ => null,
            };
        }
    }
}