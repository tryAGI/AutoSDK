//HintName: G.Models.ChatCompletionAssistantMessageParamRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionAssistantMessageParamRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionAssistantMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionAssistantMessageParamRole value)
        {
            return value switch
            {
                ChatCompletionAssistantMessageParamRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionAssistantMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionAssistantMessageParamRole.Assistant,
                _ => null,
            };
        }
    }
}