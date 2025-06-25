//HintName: G.Models.BetaMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type.<br/>
    /// For Messages, this is always `"message"`.<br/>
    /// Default Value: message
    /// </summary>
    public enum BetaMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageType value)
        {
            return value switch
            {
                BetaMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => BetaMessageType.Message,
                _ => null,
            };
        }
    }
}