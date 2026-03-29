//HintName: G.Models.ChatEvalAssistantMessageEvaluationRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message author.<br/>
    /// For an assistant message evaluation, the role is always 'assistant'<br/>
    /// @default 'assistant'<br/>
    /// Default Value: assistant
    /// </summary>
    public enum ChatEvalAssistantMessageEvaluationRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatEvalAssistantMessageEvaluationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEvalAssistantMessageEvaluationRole value)
        {
            return value switch
            {
                ChatEvalAssistantMessageEvaluationRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEvalAssistantMessageEvaluationRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatEvalAssistantMessageEvaluationRole.Assistant,
                _ => null,
            };
        }
    }
}