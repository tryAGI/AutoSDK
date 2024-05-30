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
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    public static class VectorStoreFileBatchObjectStatusExtensions
    {
        public static string ToValueString(this VectorStoreFileBatchObjectStatus value)
        {
            return value switch
            {
                VectorStoreFileBatchObjectStatus.InProgress => "in_progress",
                VectorStoreFileBatchObjectStatus.Completed => "completed",
                VectorStoreFileBatchObjectStatus.Cancelled => "cancelled",
                VectorStoreFileBatchObjectStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileBatchObjectStatus ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => VectorStoreFileBatchObjectStatus.InProgress,
                "completed" => VectorStoreFileBatchObjectStatus.Completed,
                "cancelled" => VectorStoreFileBatchObjectStatus.Cancelled,
                "failed" => VectorStoreFileBatchObjectStatus.Failed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileBatchObjectStatus ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreFileBatchObjectStatus.InProgress,
                1 => VectorStoreFileBatchObjectStatus.Completed,
                2 => VectorStoreFileBatchObjectStatus.Cancelled,
                3 => VectorStoreFileBatchObjectStatus.Failed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}