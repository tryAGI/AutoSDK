//HintName: G.Models.RealtimeServerEventResponseTextDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.text.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventResponseTextDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.text.delta")]
        ResponseTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseTextDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventResponseTextDeltaType.ResponseTextDelta => "response.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.delta" => RealtimeServerEventResponseTextDeltaType.ResponseTextDelta,
                _ => null,
            };
        }
    }
}