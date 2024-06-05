//HintName: G.Models.ChatCompletionRequestUserMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `user`.
    /// </summary>
    public enum ChatCompletionRequestUserMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestUserMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestUserMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestUserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestUserMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatCompletionRequestUserMessageRole.User,
                _ => null,
            };
        }
    }
}