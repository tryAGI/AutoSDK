//HintName: G.Models.BlobStorageIntegrationFileType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlobStorageIntegrationFileType
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Jsonl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageIntegrationFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageIntegrationFileType value)
        {
            return value switch
            {
                BlobStorageIntegrationFileType.Csv => "CSV",
                BlobStorageIntegrationFileType.Json => "JSON",
                BlobStorageIntegrationFileType.Jsonl => "JSONL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageIntegrationFileType? ToEnum(string value)
        {
            return value switch
            {
                "CSV" => BlobStorageIntegrationFileType.Csv,
                "JSON" => BlobStorageIntegrationFileType.Json,
                "JSONL" => BlobStorageIntegrationFileType.Jsonl,
                _ => null,
            };
        }
    }
}