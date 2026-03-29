//HintName: G.Models.ChatCompletionDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the author of this message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionDeltaRole value)
        {
            return value switch
            {
                ChatCompletionDeltaRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionDeltaRole.Assistant,
                _ => null,
            };
        }
    }
}