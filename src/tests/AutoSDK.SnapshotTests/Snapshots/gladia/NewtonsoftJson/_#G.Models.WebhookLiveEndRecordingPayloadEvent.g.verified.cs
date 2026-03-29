//HintName: G.Models.WebhookLiveEndRecordingPayloadEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.end_recording<br/>
    /// Example: live.end_recording
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookLiveEndRecordingPayloadEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live.end_recording")]
        LiveEndRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookLiveEndRecordingPayloadEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveEndRecordingPayloadEvent value)
        {
            return value switch
            {
                WebhookLiveEndRecordingPayloadEvent.LiveEndRecording => "live.end_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveEndRecordingPayloadEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.end_recording" => WebhookLiveEndRecordingPayloadEvent.LiveEndRecording,
                _ => null,
            };
        }
    }
}