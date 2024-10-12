//HintName: G.Models.BulkExportUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportUpdateStatus value)
        {
            return value switch
            {
                BulkExportUpdateStatus.Cancelled => "Cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "Cancelled" => BulkExportUpdateStatus.Cancelled,
                _ => null,
            };
        }
    }
}