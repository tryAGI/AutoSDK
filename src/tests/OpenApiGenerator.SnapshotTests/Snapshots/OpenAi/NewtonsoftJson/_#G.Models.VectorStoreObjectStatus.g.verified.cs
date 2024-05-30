//HintName: G.Models.VectorStoreObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
    }

    public static class VectorStoreObjectStatusExtensions
    {
        public static string ToValueString(this VectorStoreObjectStatus value)
        {
            return value switch
            {
                VectorStoreObjectStatus.Expired => "expired",
                VectorStoreObjectStatus.InProgress => "in_progress",
                VectorStoreObjectStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreObjectStatus ToEnum(string value)
        {
            return value switch
            {
                "expired" => VectorStoreObjectStatus.Expired,
                "in_progress" => VectorStoreObjectStatus.InProgress,
                "completed" => VectorStoreObjectStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreObjectStatus ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreObjectStatus.Expired,
                1 => VectorStoreObjectStatus.InProgress,
                2 => VectorStoreObjectStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}