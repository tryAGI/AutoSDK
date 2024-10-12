//HintName: G.Models.BulkEmbeddingJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BulkEmbeddingJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in-progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
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
                BulkEmbeddingJobStatus.Waiting => "waiting",
                BulkEmbeddingJobStatus.InProgress => "in-progress",
                BulkEmbeddingJobStatus.Failed => "failed",
                BulkEmbeddingJobStatus.Completed => "completed",
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
                "waiting" => BulkEmbeddingJobStatus.Waiting,
                "in-progress" => BulkEmbeddingJobStatus.InProgress,
                "failed" => BulkEmbeddingJobStatus.Failed,
                "completed" => BulkEmbeddingJobStatus.Completed,
                _ => null,
            };
        }
    }
}