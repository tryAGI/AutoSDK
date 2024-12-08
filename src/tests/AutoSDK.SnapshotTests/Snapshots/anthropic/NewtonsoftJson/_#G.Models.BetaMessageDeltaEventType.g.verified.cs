//HintName: G.Models.BetaMessageDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: message_delta
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaMessageDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_delta")]
        MessageDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageDeltaEventType value)
        {
            return value switch
            {
                BetaMessageDeltaEventType.MessageDelta => "message_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_delta" => BetaMessageDeltaEventType.MessageDelta,
                _ => null,
            };
        }
    }
}