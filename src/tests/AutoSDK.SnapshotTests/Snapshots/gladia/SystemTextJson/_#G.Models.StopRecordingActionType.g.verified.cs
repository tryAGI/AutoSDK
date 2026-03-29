//HintName: G.Models.StopRecordingActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: stop_recording<br/>
    /// Example: stop_recording
    /// </summary>
    public enum StopRecordingActionType
    {
        /// <summary>
        /// 
        /// </summary>
        StopRecording,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopRecordingActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopRecordingActionType value)
        {
            return value switch
            {
                StopRecordingActionType.StopRecording => "stop_recording",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopRecordingActionType? ToEnum(string value)
        {
            return value switch
            {
                "stop_recording" => StopRecordingActionType.StopRecording,
                _ => null,
            };
        }
    }
}