//HintName: G.Models.ChatCompletionRequestToolMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `tool`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestToolMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    public static class ChatCompletionRequestToolMessageRoleExtensions
    {
        public static string ToValueString(this ChatCompletionRequestToolMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestToolMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestToolMessageRole ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatCompletionRequestToolMessageRole.Tool,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestToolMessageRole ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestToolMessageRole.Tool,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}