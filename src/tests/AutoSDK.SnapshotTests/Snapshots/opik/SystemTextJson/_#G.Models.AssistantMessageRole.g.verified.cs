//HintName: G.Models.AssistantMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMessageRole
    {
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
    public static class AssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageRole value)
        {
            return value switch
            {
                AssistantMessageRole.Assistant => "assistant",
                AssistantMessageRole.Function => "function",
                AssistantMessageRole.System => "system",
                AssistantMessageRole.Tool => "tool",
                AssistantMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantMessageRole.Assistant,
                "function" => AssistantMessageRole.Function,
                "system" => AssistantMessageRole.System,
                "tool" => AssistantMessageRole.Tool,
                "user" => AssistantMessageRole.User,
                _ => null,
            };
        }
    }
}