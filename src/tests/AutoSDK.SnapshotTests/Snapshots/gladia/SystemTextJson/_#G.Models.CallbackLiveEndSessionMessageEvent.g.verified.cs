//HintName: G.Models.CallbackLiveEndSessionMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.end_session<br/>
    /// Example: live.end_session
    /// </summary>
    public enum CallbackLiveEndSessionMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LiveEndSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveEndSessionMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveEndSessionMessageEvent value)
        {
            return value switch
            {
                CallbackLiveEndSessionMessageEvent.LiveEndSession => "live.end_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveEndSessionMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.end_session" => CallbackLiveEndSessionMessageEvent.LiveEndSession,
                _ => null,
            };
        }
    }
}