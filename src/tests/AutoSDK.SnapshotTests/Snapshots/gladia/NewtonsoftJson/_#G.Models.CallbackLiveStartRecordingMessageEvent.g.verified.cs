//HintName: G.Models.CallbackLiveStartRecordingMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.start_recording<br/>
    /// Example: live.start_recording
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackLiveStartRecordingMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.start_recording")]
        LiveStartRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveStartRecordingMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveStartRecordingMessageEvent value)
        {
            return value switch
            {
                CallbackLiveStartRecordingMessageEvent.LiveStartRecording => "live.start_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveStartRecordingMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.start_recording" => CallbackLiveStartRecordingMessageEvent.LiveStartRecording,
                _ => null,
            };
        }
    }
}