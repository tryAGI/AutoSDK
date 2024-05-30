//HintName: G.Models.VectorStoreFileObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.
    /// </summary>
    public enum VectorStoreFileObjectStatus
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

    public static class VectorStoreFileObjectStatusExtensions
    {
        public static string ToValueString(this VectorStoreFileObjectStatus value)
        {
            return value switch
            {
                VectorStoreFileObjectStatus.InProgress => "in_progress",
                VectorStoreFileObjectStatus.Completed => "completed",
                VectorStoreFileObjectStatus.Cancelled => "cancelled",
                VectorStoreFileObjectStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileObjectStatus ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => VectorStoreFileObjectStatus.InProgress,
                "completed" => VectorStoreFileObjectStatus.Completed,
                "cancelled" => VectorStoreFileObjectStatus.Cancelled,
                "failed" => VectorStoreFileObjectStatus.Failed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileObjectStatus ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreFileObjectStatus.InProgress,
                1 => VectorStoreFileObjectStatus.Completed,
                2 => VectorStoreFileObjectStatus.Cancelled,
                3 => VectorStoreFileObjectStatus.Failed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}