//HintName: G.Models.EndRecordingMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: end_recording<br/>
    /// Example: end_recording
    /// </summary>
    public enum EndRecordingMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        EndRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndRecordingMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndRecordingMessageType value)
        {
            return value switch
            {
                EndRecordingMessageType.EndRecording => "end_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndRecordingMessageType? ToEnum(string value)
        {
            return value switch
            {
                "end_recording" => EndRecordingMessageType.EndRecording,
                _ => null,
            };
        }
    }
}