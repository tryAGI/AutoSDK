//HintName: G.Models.TranscriptReadyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the transcript. Either completed or error.
    /// </summary>
    public enum TranscriptReadyStatus
    {
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