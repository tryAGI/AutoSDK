//HintName: G.Models.ChatCompletionUserMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the role of the author of this message<br/>
    /// Default Value: user
    /// </summary>
    public enum ChatCompletionUserMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageRole value)
        {
            return value switch
            {
                ChatCompletionUserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatCompletionUserMessageRole.User,
                _ => null,
            };
        }
    }
}