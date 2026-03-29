//HintName: G.Models.CallbackLiveEndRecordingMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.end_recording<br/>
    /// Example: live.end_recording
    /// </summary>
    public enum CallbackLiveEndRecordingMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LiveEndRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveEndRecordingMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveEndRecordingMessageEvent value)
        {
            return value switch
            {
                CallbackLiveEndRecordingMessageEvent.LiveEndRecording => "live.end_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveEndRecordingMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.end_recording" => CallbackLiveEndRecordingMessageEvent.LiveEndRecording,
                _ => null,
            };
        }
    }
}