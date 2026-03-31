//HintName: G.Models.ChatCompletionMessageParamAssistantRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionMessageParamAssistantRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageParamAssistantRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageParamAssistantRole value)
        {
            return value switch
            {
                ChatCompletionMessageParamAssistantRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageParamAssistantRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionMessageParamAssistantRole.Assistant,
                _ => null,
            };
        }
    }
}