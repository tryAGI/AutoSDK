//HintName: G.Models.ChatCompletionAssistantMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the role of the author of this message<br/>
    /// Default Value: assistant
    /// </summary>
    public enum ChatCompletionAssistantMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionAssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionAssistantMessageRole value)
        {
            return value switch
            {
                ChatCompletionAssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionAssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionAssistantMessageRole.Assistant,
                _ => null,
            };
        }
    }
}