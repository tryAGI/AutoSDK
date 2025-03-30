//HintName: G.Models.SpeakerSeparationResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeakerSeparationResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
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
                SpeakerSeparationResponseModelStatus.NotStarted => "not_started",
                SpeakerSeparationResponseModelStatus.Pending => "pending",
                SpeakerSeparationResponseModelStatus.Completed => "completed",
                SpeakerSeparationResponseModelStatus.Failed => "failed",
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
                "not_started" => SpeakerSeparationResponseModelStatus.NotStarted,
                "pending" => SpeakerSeparationResponseModelStatus.Pending,
                "completed" => SpeakerSeparationResponseModelStatus.Completed,
                "failed" => SpeakerSeparationResponseModelStatus.Failed,
                _ => null,
            };
        }
    }
}