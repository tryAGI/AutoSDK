//HintName: G.Models.BetaMessageStartEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: message_start
    /// </summary>
    public enum BetaMessageStartEventType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageStartEventType value)
        {
            return value switch
            {
                BetaMessageStartEventType.MessageStart => "message_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_start" => BetaMessageStartEventType.MessageStart,
                _ => null,
            };
        }
    }
}