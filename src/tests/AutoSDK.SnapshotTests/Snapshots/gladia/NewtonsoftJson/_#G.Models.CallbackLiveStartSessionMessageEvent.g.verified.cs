//HintName: G.Models.CallbackLiveStartSessionMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.start_session<br/>
    /// Example: live.start_session
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackLiveStartSessionMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.start_session")]
        LiveStartSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveStartSessionMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveStartSessionMessageEvent value)
        {
            return value switch
            {
                CallbackLiveStartSessionMessageEvent.LiveStartSession => "live.start_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveStartSessionMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.start_session" => CallbackLiveStartSessionMessageEvent.LiveStartSession,
                _ => null,
            };
        }
    }
}