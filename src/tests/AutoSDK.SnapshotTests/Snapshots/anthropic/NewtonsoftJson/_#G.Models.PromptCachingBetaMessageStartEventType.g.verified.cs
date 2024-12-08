//HintName: G.Models.PromptCachingBetaMessageStartEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: message_start
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCachingBetaMessageStartEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_start")]
        MessageStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaMessageStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaMessageStartEventType value)
        {
            return value switch
            {
                PromptCachingBetaMessageStartEventType.MessageStart => "message_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaMessageStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_start" => PromptCachingBetaMessageStartEventType.MessageStart,
                _ => null,
            };
        }
    }
}