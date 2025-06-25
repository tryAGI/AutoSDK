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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => VectorStoreFileObjectStatus.InProgress,
                "completed" => VectorStoreFileObjectStatus.Completed,
                "cancelled" => VectorStoreFileObjectStatus.Cancelled,
                "failed" => VectorStoreFileObjectStatus.Failed,
                _ => null,
            };
        }
    }
}