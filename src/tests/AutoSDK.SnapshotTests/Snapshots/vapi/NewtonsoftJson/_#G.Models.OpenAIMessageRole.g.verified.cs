//HintName: G.Models.OpenAIMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIMessageRole value)
        {
            return value switch
            {
                OpenAIMessageRole.Assistant => "assistant",
                OpenAIMessageRole.Function => "function",
                OpenAIMessageRole.System => "system",
                OpenAIMessageRole.Tool => "tool",
                OpenAIMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OpenAIMessageRole.Assistant,
                "function" => OpenAIMessageRole.Function,
                "system" => OpenAIMessageRole.System,
                "tool" => OpenAIMessageRole.Tool,
                "user" => OpenAIMessageRole.User,
                _ => null,
            };
        }
    }
}