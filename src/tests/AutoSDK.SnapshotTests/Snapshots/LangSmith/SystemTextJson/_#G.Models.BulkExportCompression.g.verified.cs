//HintName: G.Models.BulkExportCompression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkExportCompression
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Gzip,
        /// <summary>
        /// 
        /// </summary>
        Snappy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkExportCompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkExportCompression value)
        {
            return value switch
            {
                BulkExportCompression.None => "none",
                BulkExportCompression.Gzip => "gzip",
                BulkExportCompression.Snappy => "snappy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkExportCompression? ToEnum(string value)
        {
            return value switch
            {
                "none" => BulkExportCompression.None,
                "gzip" => BulkExportCompression.Gzip,
                "snappy" => BulkExportCompression.Snappy,
                _ => null,
            };
        }
    }
}