//HintName: G.Models.BulkExportRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BulkExportRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TimedOut")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Running")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportRunStatus value)
        {
            return value switch
            {
                BulkExportRunStatus.Cancelled => "Cancelled",
                BulkExportRunStatus.Completed => "Completed",
                BulkExportRunStatus.Created => "Created",
                BulkExportRunStatus.Failed => "Failed",
                BulkExportRunStatus.TimedOut => "TimedOut",
                BulkExportRunStatus.Running => "Running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => BulkExportRunStatus.Cancelled,
                "Completed" => BulkExportRunStatus.Completed,
                "Created" => BulkExportRunStatus.Created,
                "Failed" => BulkExportRunStatus.Failed,
                "TimedOut" => BulkExportRunStatus.TimedOut,
                "Running" => BulkExportRunStatus.Running,
                _ => null,
            };
        }
    }
}