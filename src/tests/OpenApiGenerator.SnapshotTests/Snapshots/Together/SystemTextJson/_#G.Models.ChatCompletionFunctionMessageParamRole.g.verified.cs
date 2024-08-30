//HintName: G.Models.ChatCompletionFunctionMessageParamRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionFunctionMessageParamRole
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionFunctionMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionFunctionMessageParamRole value)
        {
            return value switch
            {
                ChatCompletionFunctionMessageParamRole.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionFunctionMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionFunctionMessageParamRole.Function,
                _ => null,
            };
        }
    }
}