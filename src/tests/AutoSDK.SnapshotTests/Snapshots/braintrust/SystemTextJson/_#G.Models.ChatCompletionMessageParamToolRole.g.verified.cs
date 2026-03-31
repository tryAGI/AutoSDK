//HintName: G.Models.ChatCompletionMessageParamToolRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionMessageParamToolRole
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageParamToolRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageParamToolRole value)
        {
            return value switch
            {
                ChatCompletionMessageParamToolRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageParamToolRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatCompletionMessageParamToolRole.Tool,
                _ => null,
            };
        }
    }
}