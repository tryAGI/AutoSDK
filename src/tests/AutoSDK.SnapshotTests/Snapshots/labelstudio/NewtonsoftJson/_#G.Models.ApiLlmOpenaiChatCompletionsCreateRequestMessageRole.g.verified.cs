//HintName: G.Models.ApiLlmOpenaiChatCompletionsCreateRequestMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message author
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiLlmOpenaiChatCompletionsCreateRequestMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiLlmOpenaiChatCompletionsCreateRequestMessageRole value)
        {
            return value switch
            {
                ApiLlmOpenaiChatCompletionsCreateRequestMessageRole.Assistant => "assistant",
                ApiLlmOpenaiChatCompletionsCreateRequestMessageRole.System => "system",
                ApiLlmOpenaiChatCompletionsCreateRequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiLlmOpenaiChatCompletionsCreateRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ApiLlmOpenaiChatCompletionsCreateRequestMessageRole.Assistant,
                "system" => ApiLlmOpenaiChatCompletionsCreateRequestMessageRole.System,
                "user" => ApiLlmOpenaiChatCompletionsCreateRequestMessageRole.User,
                _ => null,
            };
        }
    }
}