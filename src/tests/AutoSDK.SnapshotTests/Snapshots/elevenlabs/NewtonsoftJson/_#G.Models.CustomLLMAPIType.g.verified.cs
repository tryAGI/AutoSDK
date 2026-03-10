//HintName: G.Models.CustomLLMAPIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomLLMAPIType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat_completions")]
        ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="responses")]
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomLLMAPITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMAPIType value)
        {
            return value switch
            {
                CustomLLMAPIType.ChatCompletions => "chat_completions",
                CustomLLMAPIType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMAPIType? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => CustomLLMAPIType.ChatCompletions,
                "responses" => CustomLLMAPIType.Responses,
                _ => null,
            };
        }
    }
}