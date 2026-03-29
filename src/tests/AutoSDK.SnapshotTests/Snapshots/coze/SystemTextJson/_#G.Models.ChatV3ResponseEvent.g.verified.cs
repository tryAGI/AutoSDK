//HintName: G.Models.ChatV3ResponseEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatV3ResponseEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        ConversationChatCompleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationChatCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationChatFailed,
        /// <summary>
        /// 
        /// </summary>
        ConversationChatInProgress,
        /// <summary>
        /// 
        /// </summary>
        ConversationChatRequiresAction,
        /// <summary>
        /// 
        /// </summary>
        ConversationMessageCompleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationMessageDelta,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatV3ResponseEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatV3ResponseEvent value)
        {
            return value switch
            {
                ChatV3ResponseEvent.ConversationAudioDelta => "conversation.audio.delta",
                ChatV3ResponseEvent.ConversationChatCompleted => "conversation.chat.completed",
                ChatV3ResponseEvent.ConversationChatCreated => "conversation.chat.created",
                ChatV3ResponseEvent.ConversationChatFailed => "conversation.chat.failed",
                ChatV3ResponseEvent.ConversationChatInProgress => "conversation.chat.in_progress",
                ChatV3ResponseEvent.ConversationChatRequiresAction => "conversation.chat.requires_action",
                ChatV3ResponseEvent.ConversationMessageCompleted => "conversation.message.completed",
                ChatV3ResponseEvent.ConversationMessageDelta => "conversation.message.delta",
                ChatV3ResponseEvent.Done => "done",
                ChatV3ResponseEvent.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatV3ResponseEvent? ToEnum(string value)
        {
            return value switch
            {
                "conversation.audio.delta" => ChatV3ResponseEvent.ConversationAudioDelta,
                "conversation.chat.completed" => ChatV3ResponseEvent.ConversationChatCompleted,
                "conversation.chat.created" => ChatV3ResponseEvent.ConversationChatCreated,
                "conversation.chat.failed" => ChatV3ResponseEvent.ConversationChatFailed,
                "conversation.chat.in_progress" => ChatV3ResponseEvent.ConversationChatInProgress,
                "conversation.chat.requires_action" => ChatV3ResponseEvent.ConversationChatRequiresAction,
                "conversation.message.completed" => ChatV3ResponseEvent.ConversationMessageCompleted,
                "conversation.message.delta" => ChatV3ResponseEvent.ConversationMessageDelta,
                "done" => ChatV3ResponseEvent.Done,
                "error" => ChatV3ResponseEvent.Error,
                _ => null,
            };
        }
    }
}