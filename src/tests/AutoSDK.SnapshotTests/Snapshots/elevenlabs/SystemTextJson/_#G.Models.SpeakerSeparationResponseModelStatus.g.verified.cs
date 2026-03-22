//HintName: G.Models.SpeakerSeparationResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the speaker separation.
    /// </summary>
    public enum SpeakerSeparationResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakerSeparationResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakerSeparationResponseModelStatus value)
        {
            return value switch
            {
                SpeakerSeparationResponseModelStatus.Completed => "completed",
                SpeakerSeparationResponseModelStatus.Failed => "failed",
                SpeakerSeparationResponseModelStatus.NotStarted => "not_started",
                SpeakerSeparationResponseModelStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakerSeparationResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SpeakerSeparationResponseModelStatus.Completed,
                "failed" => SpeakerSeparationResponseModelStatus.Failed,
                "not_started" => SpeakerSeparationResponseModelStatus.NotStarted,
                "pending" => SpeakerSeparationResponseModelStatus.Pending,
                _ => null,
            };
        }
    }
}