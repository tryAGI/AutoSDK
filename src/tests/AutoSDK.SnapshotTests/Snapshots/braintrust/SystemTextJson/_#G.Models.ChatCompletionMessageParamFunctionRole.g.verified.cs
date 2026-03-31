//HintName: G.Models.ChatCompletionMessageParamFunctionRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionMessageParamFunctionRole
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageParamFunctionRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageParamFunctionRole value)
        {
            return value switch
            {
                ChatCompletionMessageParamFunctionRole.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageParamFunctionRole? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionMessageParamFunctionRole.Function,
                _ => null,
            };
        }
    }
}