//HintName: G.Models.ChatCompletionRequestSystemMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `system`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestSystemMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
    }

    public static class ChatCompletionRequestSystemMessageRoleExtensions
    {
        public static string ToValueString(this ChatCompletionRequestSystemMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestSystemMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestSystemMessageRole ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionRequestSystemMessageRole.System,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestSystemMessageRole ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestSystemMessageRole.System,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}