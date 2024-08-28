//HintName: G.Models.ChatMessageStartEventVariant2DeltaMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message.
    /// </summary>
    public enum ChatMessageStartEventVariant2DeltaMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageStartEventVariant2DeltaMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageStartEventVariant2DeltaMessageRole value)
        {
            return value switch
            {
                ChatMessageStartEventVariant2DeltaMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageStartEventVariant2DeltaMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageStartEventVariant2DeltaMessageRole.Assistant,
                _ => null,
            };
        }
    }
}