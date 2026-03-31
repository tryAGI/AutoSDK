//HintName: G.Models.ChatCompletionRequestMessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestMessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageDiscriminatorRole value)
        {
            return value switch
            {
                ChatCompletionRequestMessageDiscriminatorRole.Assistant => "assistant",
                ChatCompletionRequestMessageDiscriminatorRole.Developer => "developer",
                ChatCompletionRequestMessageDiscriminatorRole.Function => "function",
                ChatCompletionRequestMessageDiscriminatorRole.System => "system",
                ChatCompletionRequestMessageDiscriminatorRole.Tool => "tool",
                ChatCompletionRequestMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionRequestMessageDiscriminatorRole.Assistant,
                "developer" => ChatCompletionRequestMessageDiscriminatorRole.Developer,
                "function" => ChatCompletionRequestMessageDiscriminatorRole.Function,
                "system" => ChatCompletionRequestMessageDiscriminatorRole.System,
                "tool" => ChatCompletionRequestMessageDiscriminatorRole.Tool,
                "user" => ChatCompletionRequestMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}