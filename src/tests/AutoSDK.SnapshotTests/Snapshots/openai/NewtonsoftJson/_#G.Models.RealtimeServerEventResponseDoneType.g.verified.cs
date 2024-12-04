//HintName: G.Models.RealtimeServerEventResponseDoneType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.done`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventResponseDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.done")]
        ResponseDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseDoneType.ResponseDone => "response.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.done" => RealtimeServerEventResponseDoneType.ResponseDone,
                _ => null,
            };
        }
    }
}