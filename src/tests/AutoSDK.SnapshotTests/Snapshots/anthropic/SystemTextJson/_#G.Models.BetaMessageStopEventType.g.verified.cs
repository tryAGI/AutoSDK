//HintName: G.Models.BetaMessageStopEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: message_stop
    /// </summary>
    public enum BetaMessageStopEventType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageStopEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageStopEventType value)
        {
            return value switch
            {
                BetaMessageStopEventType.MessageStop => "message_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageStopEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_stop" => BetaMessageStopEventType.MessageStop,
                _ => null,
            };
        }
    }
}