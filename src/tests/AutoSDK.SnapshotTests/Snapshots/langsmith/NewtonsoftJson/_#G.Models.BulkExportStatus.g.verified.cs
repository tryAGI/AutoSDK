//HintName: G.Models.BulkExportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BulkExportStatus
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
    public static class BulkExportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportStatus value)
        {
            return value switch
            {
                BulkExportStatus.Cancelled => "Cancelled",
                BulkExportStatus.Completed => "Completed",
                BulkExportStatus.Created => "Created",
                BulkExportStatus.Failed => "Failed",
                BulkExportStatus.TimedOut => "TimedOut",
                BulkExportStatus.Running => "Running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => BulkExportStatus.Cancelled,
                "Completed" => BulkExportStatus.Completed,
                "Created" => BulkExportStatus.Created,
                "Failed" => BulkExportStatus.Failed,
                "TimedOut" => BulkExportStatus.TimedOut,
                "Running" => BulkExportStatus.Running,
                _ => null,
            };
        }
    }
}