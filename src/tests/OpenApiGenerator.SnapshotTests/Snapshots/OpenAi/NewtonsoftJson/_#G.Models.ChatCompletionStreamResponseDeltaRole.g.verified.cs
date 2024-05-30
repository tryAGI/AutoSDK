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
    }

    public static class ChatCompletionStreamResponseDeltaRoleExtensions
    {
        public static string ToValueString(this ChatCompletionStreamResponseDeltaRole value)
        {
            return value switch
            {
                ChatCompletionStreamResponseDeltaRole.System => "system",
                ChatCompletionStreamResponseDeltaRole.User => "user",
                ChatCompletionStreamResponseDeltaRole.Assistant => "assistant",
                ChatCompletionStreamResponseDeltaRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionStreamResponseDeltaRole ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionStreamResponseDeltaRole.System,
                "user" => ChatCompletionStreamResponseDeltaRole.User,
                "assistant" => ChatCompletionStreamResponseDeltaRole.Assistant,
                "tool" => ChatCompletionStreamResponseDeltaRole.Tool,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionStreamResponseDeltaRole ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionStreamResponseDeltaRole.System,
                1 => ChatCompletionStreamResponseDeltaRole.User,
                2 => ChatCompletionStreamResponseDeltaRole.Assistant,
                3 => ChatCompletionStreamResponseDeltaRole.Tool,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}