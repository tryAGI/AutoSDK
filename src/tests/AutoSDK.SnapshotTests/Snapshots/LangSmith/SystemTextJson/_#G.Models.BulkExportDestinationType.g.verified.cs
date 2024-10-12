//HintName: G.Models.BulkExportDestinationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportDestinationType value)
        {
            return value switch
            {
                BulkExportDestinationType.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "s3" => BulkExportDestinationType.S3,
                _ => null,
            };
        }
    }
}