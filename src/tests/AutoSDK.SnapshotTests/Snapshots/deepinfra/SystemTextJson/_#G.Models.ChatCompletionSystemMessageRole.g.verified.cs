//HintName: G.Models.ChatCompletionSystemMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the role of the author of this message<br/>
    /// Default Value: system
    /// </summary>
    public enum ChatCompletionSystemMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionSystemMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionSystemMessageRole value)
        {
            return value switch
            {
                ChatCompletionSystemMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionSystemMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionSystemMessageRole.System,
                _ => null,
            };
        }
    }
}