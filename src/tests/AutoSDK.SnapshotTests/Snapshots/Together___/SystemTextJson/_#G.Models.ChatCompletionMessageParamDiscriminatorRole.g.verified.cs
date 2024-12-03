//HintName: G.Models.ChatCompletionMessageParamDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionMessageParamDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageParamDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageParamDiscriminatorRole value)
        {
            return value switch
            {
                ChatCompletionMessageParamDiscriminatorRole.System => "system",
                ChatCompletionMessageParamDiscriminatorRole.User => "user",
                ChatCompletionMessageParamDiscriminatorRole.Assistant => "assistant",
                ChatCompletionMessageParamDiscriminatorRole.Tool => "tool",
                ChatCompletionMessageParamDiscriminatorRole.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageParamDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionMessageParamDiscriminatorRole.System,
                "user" => ChatCompletionMessageParamDiscriminatorRole.User,
                "assistant" => ChatCompletionMessageParamDiscriminatorRole.Assistant,
                "tool" => ChatCompletionMessageParamDiscriminatorRole.Tool,
                "function" => ChatCompletionMessageParamDiscriminatorRole.Function,
                _ => null,
            };
        }
    }
}