//HintName: G.Models.FineTuneChatCompletionRequestAssistantMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `assistant`.
    /// </summary>
    public enum FineTuneChatCompletionRequestAssistantMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneChatCompletionRequestAssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneChatCompletionRequestAssistantMessageRole value)
        {
            return value switch
            {
                FineTuneChatCompletionRequestAssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneChatCompletionRequestAssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => FineTuneChatCompletionRequestAssistantMessageRole.Assistant,
                _ => null,
            };
        }
    }
}