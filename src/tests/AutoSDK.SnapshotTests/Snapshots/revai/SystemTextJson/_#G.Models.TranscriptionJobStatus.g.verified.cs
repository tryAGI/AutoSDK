//HintName: G.Models.TranscriptionJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the job
    /// </summary>
    public enum TranscriptionJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Transcribed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionJobStatus value)
        {
            return value switch
            {
                TranscriptionJobStatus.Failed => "failed",
                TranscriptionJobStatus.InProgress => "in_progress",
                TranscriptionJobStatus.Transcribed => "transcribed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => TranscriptionJobStatus.Failed,
                "in_progress" => TranscriptionJobStatus.InProgress,
                "transcribed" => TranscriptionJobStatus.Transcribed,
                _ => null,
            };
        }
    }
}