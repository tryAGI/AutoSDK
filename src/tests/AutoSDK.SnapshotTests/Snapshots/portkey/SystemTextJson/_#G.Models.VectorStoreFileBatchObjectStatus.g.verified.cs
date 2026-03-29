//HintName: G.Models.VectorStoreFileBatchObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the vector store files batch, which can be either `in_progress`, `completed`, `cancelled` or `failed`.
    /// </summary>
    public enum VectorStoreFileBatchObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileBatchObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileBatchObjectStatus value)
        {
            return value switch
            {
                VectorStoreFileBatchObjectStatus.Cancelled => "cancelled",
                VectorStoreFileBatchObjectStatus.Completed => "completed",
                VectorStoreFileBatchObjectStatus.Failed => "failed",
                VectorStoreFileBatchObjectStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileBatchObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => VectorStoreFileBatchObjectStatus.Cancelled,
                "completed" => VectorStoreFileBatchObjectStatus.Completed,
                "failed" => VectorStoreFileBatchObjectStatus.Failed,
                "in_progress" => VectorStoreFileBatchObjectStatus.InProgress,
                _ => null,
            };
        }
    }
}