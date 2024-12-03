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
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
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
                TranscriptStatus.Queued => "queued",
                TranscriptStatus.Processing => "processing",
                TranscriptStatus.Completed => "completed",
                TranscriptStatus.Error => "error",
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
                "queued" => TranscriptStatus.Queued,
                "processing" => TranscriptStatus.Processing,
                "completed" => TranscriptStatus.Completed,
                "error" => TranscriptStatus.Error,
                _ => null,
            };
        }
    }
}