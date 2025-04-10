//HintName: G.Models.EventsEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `call.started` - Fired when a call starts<br/>
    /// * `call.joined` - Fired when a call is joined<br/>
    /// * `call.ended` - Fired when a call ends
    /// </summary>
    public enum EventsEnum
    {
        /// <summary>
        /// 
        /// </summary>
        CallStarted,
        /// <summary>
        /// 
        /// </summary>
        CallJoined,
        /// <summary>
        /// 
        /// </summary>
        CallEnded,
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
                EventsEnum.CallStarted => "call.started",
                EventsEnum.CallJoined => "call.joined",
                EventsEnum.CallEnded => "call.ended",
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
                "call.started" => EventsEnum.CallStarted,
                "call.joined" => EventsEnum.CallJoined,
                "call.ended" => EventsEnum.CallEnded,
                _ => null,
            };
        }
    }
}