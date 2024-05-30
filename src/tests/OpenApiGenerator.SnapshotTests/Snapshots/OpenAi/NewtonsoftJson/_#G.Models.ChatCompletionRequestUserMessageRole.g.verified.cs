//HintName: G.Models.ChatCompletionRequestUserMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `user`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestUserMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    public static class ChatCompletionRequestUserMessageRoleExtensions
    {
        public static string ToValueString(this ChatCompletionRequestUserMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestUserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestUserMessageRole ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatCompletionRequestUserMessageRole.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestUserMessageRole ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestUserMessageRole.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}