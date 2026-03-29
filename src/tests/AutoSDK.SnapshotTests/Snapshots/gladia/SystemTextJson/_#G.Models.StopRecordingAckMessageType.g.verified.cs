//HintName: G.Models.StopRecordingAckMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: stop_recording<br/>
    /// Example: stop_recording
    /// </summary>
    public enum StopRecordingAckMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        StopRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopRecordingAckMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopRecordingAckMessageType value)
        {
            return value switch
            {
                StopRecordingAckMessageType.StopRecording => "stop_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopRecordingAckMessageType? ToEnum(string value)
        {
            return value switch
            {
                "stop_recording" => StopRecordingAckMessageType.StopRecording,
                _ => null,
            };
        }
    }
}