//HintName: G.Models.SubmitToolOutputsResponseEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubmitToolOutputsResponseEvent
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
    public static class SubmitToolOutputsResponseEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitToolOutputsResponseEvent value)
        {
            return value switch
            {
                SubmitToolOutputsResponseEvent.ConversationAudioDelta => "conversation.audio.delta",
                SubmitToolOutputsResponseEvent.ConversationChatCompleted => "conversation.chat.completed",
                SubmitToolOutputsResponseEvent.ConversationChatCreated => "conversation.chat.created",
                SubmitToolOutputsResponseEvent.ConversationChatFailed => "conversation.chat.failed",
                SubmitToolOutputsResponseEvent.ConversationChatInProgress => "conversation.chat.in_progress",
                SubmitToolOutputsResponseEvent.ConversationChatRequiresAction => "conversation.chat.requires_action",
                SubmitToolOutputsResponseEvent.ConversationMessageCompleted => "conversation.message.completed",
                SubmitToolOutputsResponseEvent.ConversationMessageDelta => "conversation.message.delta",
                SubmitToolOutputsResponseEvent.Done => "done",
                SubmitToolOutputsResponseEvent.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitToolOutputsResponseEvent? ToEnum(string value)
        {
            return value switch
            {
                "conversation.audio.delta" => SubmitToolOutputsResponseEvent.ConversationAudioDelta,
                "conversation.chat.completed" => SubmitToolOutputsResponseEvent.ConversationChatCompleted,
                "conversation.chat.created" => SubmitToolOutputsResponseEvent.ConversationChatCreated,
                "conversation.chat.failed" => SubmitToolOutputsResponseEvent.ConversationChatFailed,
                "conversation.chat.in_progress" => SubmitToolOutputsResponseEvent.ConversationChatInProgress,
                "conversation.chat.requires_action" => SubmitToolOutputsResponseEvent.ConversationChatRequiresAction,
                "conversation.message.completed" => SubmitToolOutputsResponseEvent.ConversationMessageCompleted,
                "conversation.message.delta" => SubmitToolOutputsResponseEvent.ConversationMessageDelta,
                "done" => SubmitToolOutputsResponseEvent.Done,
                "error" => SubmitToolOutputsResponseEvent.Error,
                _ => null,
            };
        }
    }
}