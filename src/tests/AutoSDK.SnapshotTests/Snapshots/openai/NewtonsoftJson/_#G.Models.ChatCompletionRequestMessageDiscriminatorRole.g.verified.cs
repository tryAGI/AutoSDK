//HintName: G.Models.ChatCompletionRequestMessageDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestMessageDiscriminatorRole
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageDiscriminatorRole value)
        {
            return value switch
            {
                ChatCompletionRequestMessageDiscriminatorRole.System => "system",
                ChatCompletionRequestMessageDiscriminatorRole.User => "user",
                ChatCompletionRequestMessageDiscriminatorRole.Assistant => "assistant",
                ChatCompletionRequestMessageDiscriminatorRole.Tool => "tool",
                ChatCompletionRequestMessageDiscriminatorRole.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionRequestMessageDiscriminatorRole.System,
                "user" => ChatCompletionRequestMessageDiscriminatorRole.User,
                "assistant" => ChatCompletionRequestMessageDiscriminatorRole.Assistant,
                "tool" => ChatCompletionRequestMessageDiscriminatorRole.Tool,
                "function" => ChatCompletionRequestMessageDiscriminatorRole.Function,
                _ => null,
            };
        }
    }
}