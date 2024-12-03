//HintName: G.Models.BulkExportFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Parquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportFormat value)
        {
            return value switch
            {
                BulkExportFormat.Parquet => "Parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "Parquet" => BulkExportFormat.Parquet,
                _ => null,
            };
        }
    }
}