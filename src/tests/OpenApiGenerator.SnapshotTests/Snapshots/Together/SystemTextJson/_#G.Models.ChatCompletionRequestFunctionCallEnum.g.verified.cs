//HintName: G.Models.ChatCompletionRequestFunctionCallEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestFunctionCallEnum
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestFunctionCallEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestFunctionCallEnum value)
        {
            return value switch
            {
                ChatCompletionRequestFunctionCallEnum.None => "none",
                ChatCompletionRequestFunctionCallEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestFunctionCallEnum? ToEnum(string value)
        {
            return value switch
            {
                "none" => ChatCompletionRequestFunctionCallEnum.None,
                "auto" => ChatCompletionRequestFunctionCallEnum.Auto,
                _ => null,
            };
        }
    }
}