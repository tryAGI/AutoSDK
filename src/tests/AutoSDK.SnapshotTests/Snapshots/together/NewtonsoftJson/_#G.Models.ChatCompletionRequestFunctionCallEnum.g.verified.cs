//HintName: G.Models.ChatCompletionRequestFunctionCallEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestFunctionCallEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
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
                ChatCompletionRequestFunctionCallEnum.Auto => "auto",
                ChatCompletionRequestFunctionCallEnum.None => "none",
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
                "auto" => ChatCompletionRequestFunctionCallEnum.Auto,
                "none" => ChatCompletionRequestFunctionCallEnum.None,
                _ => null,
            };
        }
    }
}