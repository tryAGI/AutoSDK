//HintName: G.Models.StoreFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StoreFileStatus
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
    public static class StoreFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreFileStatus value)
        {
            return value switch
            {
                StoreFileStatus.Cancelled => "cancelled",
                StoreFileStatus.Completed => "completed",
                StoreFileStatus.Failed => "failed",
                StoreFileStatus.InProgress => "in_progress",
                StoreFileStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => StoreFileStatus.Cancelled,
                "completed" => StoreFileStatus.Completed,
                "failed" => StoreFileStatus.Failed,
                "in_progress" => StoreFileStatus.InProgress,
                "pending" => StoreFileStatus.Pending,
                _ => null,
            };
        }
    }
}