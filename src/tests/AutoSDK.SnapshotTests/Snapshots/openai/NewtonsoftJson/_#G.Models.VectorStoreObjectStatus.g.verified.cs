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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "expired" => VectorStoreObjectStatus.Expired,
                "in_progress" => VectorStoreObjectStatus.InProgress,
                "completed" => VectorStoreObjectStatus.Completed,
                _ => null,
            };
        }
    }
}