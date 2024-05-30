//HintName: G.Models.ChatCompletionRequestFunctionMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `function`.
    /// </summary>
    public enum ChatCompletionRequestFunctionMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestFunctionMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestFunctionMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestFunctionMessageRole.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestFunctionMessageRole ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionRequestFunctionMessageRole.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}