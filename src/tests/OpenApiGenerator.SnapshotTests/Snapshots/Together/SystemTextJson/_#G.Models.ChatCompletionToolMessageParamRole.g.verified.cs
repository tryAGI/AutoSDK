//HintName: G.Models.ChatCompletionToolMessageParamRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionToolMessageParamRole
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionToolMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionToolMessageParamRole value)
        {
            return value switch
            {
                ChatCompletionToolMessageParamRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionToolMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatCompletionToolMessageParamRole.Tool,
                _ => null,
            };
        }
    }
}