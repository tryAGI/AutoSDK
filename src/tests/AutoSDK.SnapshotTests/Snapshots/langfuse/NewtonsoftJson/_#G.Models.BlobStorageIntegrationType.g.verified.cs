//HintName: G.Models.BlobStorageIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BlobStorageIntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_BLOB_STORAGE")]
        AzureBlobStorage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="S3")]
        S3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="S3_COMPATIBLE")]
        S3Compatible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageIntegrationType value)
        {
            return value switch
            {
                BlobStorageIntegrationType.AzureBlobStorage => "AZURE_BLOB_STORAGE",
                BlobStorageIntegrationType.S3 => "S3",
                BlobStorageIntegrationType.S3Compatible => "S3_COMPATIBLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE_BLOB_STORAGE" => BlobStorageIntegrationType.AzureBlobStorage,
                "S3" => BlobStorageIntegrationType.S3,
                "S3_COMPATIBLE" => BlobStorageIntegrationType.S3Compatible,
                _ => null,
            };
        }
    }
}