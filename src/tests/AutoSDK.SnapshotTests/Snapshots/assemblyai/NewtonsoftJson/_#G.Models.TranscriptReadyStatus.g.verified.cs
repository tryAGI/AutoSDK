//HintName: G.Models.TranscriptReadyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the transcript. Either completed or error.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptReadyStatus
    {
        /// <summary>
        /// The transcript job has been completed successfully.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// An error occurred while processing the audio file.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptReadyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptReadyStatus value)
        {
            return value switch
            {
                TranscriptReadyStatus.Completed => "completed",
                TranscriptReadyStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptReadyStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TranscriptReadyStatus.Completed,
                "error" => TranscriptReadyStatus.Error,
                _ => null,
            };
        }
    }
}