//HintName: G.Models.CallbackLiveStopRecordingAckMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.stop_recording<br/>
    /// Example: live.stop_recording
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackLiveStopRecordingAckMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.stop_recording")]
        LiveStopRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveStopRecordingAckMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveStopRecordingAckMessageEvent value)
        {
            return value switch
            {
                CallbackLiveStopRecordingAckMessageEvent.LiveStopRecording => "live.stop_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveStopRecordingAckMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.stop_recording" => CallbackLiveStopRecordingAckMessageEvent.LiveStopRecording,
                _ => null,
            };
        }
    }
}