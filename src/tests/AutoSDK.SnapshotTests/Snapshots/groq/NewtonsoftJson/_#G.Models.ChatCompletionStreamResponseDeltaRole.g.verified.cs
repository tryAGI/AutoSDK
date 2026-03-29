//HintName: G.Models.ChatCompletionStreamResponseDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the author of this message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionStreamResponseDeltaRole
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
    public static class ChatCompletionStreamResponseDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionStreamResponseDeltaRole value)
        {
            return value switch
            {
                ChatCompletionStreamResponseDeltaRole.Assistant => "assistant",
                ChatCompletionStreamResponseDeltaRole.System => "system",
                ChatCompletionStreamResponseDeltaRole.Tool => "tool",
                ChatCompletionStreamResponseDeltaRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionStreamResponseDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionStreamResponseDeltaRole.Assistant,
                "system" => ChatCompletionStreamResponseDeltaRole.System,
                "tool" => ChatCompletionStreamResponseDeltaRole.Tool,
                "user" => ChatCompletionStreamResponseDeltaRole.User,
                _ => null,
            };
        }
    }
}