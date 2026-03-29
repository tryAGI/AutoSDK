//HintName: G.Models.MessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Message role.
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Chatbot,
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
        Model,
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
                MessageRole.Assistant => "assistant",
                MessageRole.Chatbot => "chatbot",
                MessageRole.Developer => "developer",
                MessageRole.Function => "function",
                MessageRole.Model => "model",
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
                "assistant" => MessageRole.Assistant,
                "chatbot" => MessageRole.Chatbot,
                "developer" => MessageRole.Developer,
                "function" => MessageRole.Function,
                "model" => MessageRole.Model,
                "system" => MessageRole.System,
                "tool" => MessageRole.Tool,
                "user" => MessageRole.User,
                _ => null,
            };
        }
    }
}