//HintName: G.Models.EventsEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `call.started` - Fired when a call starts<br/>
    /// * `call.joined` - Fired when a call is joined<br/>
    /// * `call.ended` - Fired when a call ends
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EventsEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.ended")]
        CallEnded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.joined")]
        CallJoined,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.started")]
        CallStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsEnum value)
        {
            return value switch
            {
                EventsEnum.CallEnded => "call.ended",
                EventsEnum.CallJoined => "call.joined",
                EventsEnum.CallStarted => "call.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsEnum? ToEnum(string value)
        {
            return value switch
            {
                "call.ended" => EventsEnum.CallEnded,
                "call.joined" => EventsEnum.CallJoined,
                "call.started" => EventsEnum.CallStarted,
                _ => null,
            };
        }
    }
}