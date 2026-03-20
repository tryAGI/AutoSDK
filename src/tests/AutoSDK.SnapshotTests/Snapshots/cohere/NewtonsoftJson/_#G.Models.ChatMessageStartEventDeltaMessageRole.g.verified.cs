//HintName: G.Models.ChatMessageStartEventDeltaMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageStartEventDeltaMessageRole
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
    public static class ChatMessageStartEventDeltaMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageStartEventDeltaMessageRole value)
        {
            return value switch
            {
                ChatMessageStartEventDeltaMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageStartEventDeltaMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageStartEventDeltaMessageRole.Assistant,
                _ => null,
            };
        }
    }
}