//HintName: G.Models.WebhookLiveStartRecordingPayloadEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.start_recording<br/>
    /// Example: live.start_recording
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookLiveStartRecordingPayloadEvent
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
    public static class WebhookLiveStartRecordingPayloadEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveStartRecordingPayloadEvent value)
        {
            return value switch
            {
                WebhookLiveStartRecordingPayloadEvent.LiveStartRecording => "live.start_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveStartRecordingPayloadEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.start_recording" => WebhookLiveStartRecordingPayloadEvent.LiveStartRecording,
                _ => null,
            };
        }
    }
}