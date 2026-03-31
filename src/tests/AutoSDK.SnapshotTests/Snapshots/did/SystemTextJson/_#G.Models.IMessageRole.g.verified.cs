//HintName: G.Models.IMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IMessageRole
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
    public static class IMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IMessageRole value)
        {
            return value switch
            {
                IMessageRole.Assistant => "assistant",
                IMessageRole.Function => "function",
                IMessageRole.System => "system",
                IMessageRole.Tool => "tool",
                IMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => IMessageRole.Assistant,
                "function" => IMessageRole.Function,
                "system" => IMessageRole.System,
                "tool" => IMessageRole.Tool,
                "user" => IMessageRole.User,
                _ => null,
            };
        }
    }
}