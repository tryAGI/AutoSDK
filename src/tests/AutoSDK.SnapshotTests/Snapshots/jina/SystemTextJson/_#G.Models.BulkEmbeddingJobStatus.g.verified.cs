//HintName: G.Models.BulkEmbeddingJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum BulkEmbeddingJobStatus
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
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkEmbeddingJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkEmbeddingJobStatus value)
        {
            return value switch
            {
                BulkEmbeddingJobStatus.Completed => "completed",
                BulkEmbeddingJobStatus.Failed => "failed",
                BulkEmbeddingJobStatus.InProgress => "in-progress",
                BulkEmbeddingJobStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkEmbeddingJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BulkEmbeddingJobStatus.Completed,
                "failed" => BulkEmbeddingJobStatus.Failed,
                "in-progress" => BulkEmbeddingJobStatus.InProgress,
                "waiting" => BulkEmbeddingJobStatus.Waiting,
                _ => null,
            };
        }
    }
}