//HintName: G.Models.MessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Approval,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Summary,
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
    public static class MessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageRole value)
        {
            return value switch
            {
                MessageRole.Approval => "approval",
                MessageRole.Assistant => "assistant",
                MessageRole.Function => "function",
                MessageRole.Summary => "summary",
                MessageRole.System => "system",
                MessageRole.Tool => "tool",
                MessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageRole? ToEnum(string value)
        {
            return value switch
            {
                "approval" => MessageRole.Approval,
                "assistant" => MessageRole.Assistant,
                "function" => MessageRole.Function,
                "summary" => MessageRole.Summary,
                "system" => MessageRole.System,
                "tool" => MessageRole.Tool,
                "user" => MessageRole.User,
                _ => null,
            };
        }
    }
}