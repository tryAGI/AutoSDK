//HintName: G.Models.VectorStoreFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileStatus value)
        {
            return value switch
            {
                VectorStoreFileStatus.Cancelled => "cancelled",
                VectorStoreFileStatus.Completed => "completed",
                VectorStoreFileStatus.Failed => "failed",
                VectorStoreFileStatus.InProgress => "in_progress",
                VectorStoreFileStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => VectorStoreFileStatus.Cancelled,
                "completed" => VectorStoreFileStatus.Completed,
                "failed" => VectorStoreFileStatus.Failed,
                "in_progress" => VectorStoreFileStatus.InProgress,
                "pending" => VectorStoreFileStatus.Pending,
                _ => null,
            };
        }
    }
}