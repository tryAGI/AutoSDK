//HintName: G.Models.SpeakerSeparationResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the speaker separation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeakerSeparationResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_started")]
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
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