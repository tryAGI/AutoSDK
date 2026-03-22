//HintName: G.Models.TranscriptStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of your transcript. Possible values are queued, processing, completed, or error.
    /// </summary>
    public enum TranscriptStatus
    {
        /// <summary>
        /// The transcript job has been completed successfully.
        /// </summary>
        Completed,
        /// <summary>
        /// An error occurred while processing the audio file.
        /// </summary>
        Error,
        /// <summary>
        /// The audio file is being processed by the API.
        /// </summary>
        Processing,
        /// <summary>
        /// The audio file is in the queue to be processed by the API.
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptStatus value)
        {
            return value switch
            {
                TranscriptStatus.Completed => "completed",
                TranscriptStatus.Error => "error",
                TranscriptStatus.Processing => "processing",
                TranscriptStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TranscriptStatus.Completed,
                "error" => TranscriptStatus.Error,
                "processing" => TranscriptStatus.Processing,
                "queued" => TranscriptStatus.Queued,
                _ => null,
            };
        }
    }
}