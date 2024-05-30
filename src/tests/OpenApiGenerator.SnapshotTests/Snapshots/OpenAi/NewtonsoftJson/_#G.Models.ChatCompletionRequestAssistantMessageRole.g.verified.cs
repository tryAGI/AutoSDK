//HintName: G.Models.ChatCompletionRequestAssistantMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `assistant`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestAssistantMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    public static class ChatCompletionRequestAssistantMessageRoleExtensions
    {
        public static string ToValueString(this ChatCompletionRequestAssistantMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestAssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestAssistantMessageRole ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionRequestAssistantMessageRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestAssistantMessageRole ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestAssistantMessageRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}