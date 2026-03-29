//HintName: G.Models.StartRecordingMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: start_recording<br/>
    /// Example: start_recording
    /// </summary>
    public enum StartRecordingMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        StartRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartRecordingMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartRecordingMessageType value)
        {
            return value switch
            {
                StartRecordingMessageType.StartRecording => "start_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartRecordingMessageType? ToEnum(string value)
        {
            return value switch
            {
                "start_recording" => StartRecordingMessageType.StartRecording,
                _ => null,
            };
        }
    }
}