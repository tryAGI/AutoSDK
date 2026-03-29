//HintName: G.Models.AzureCredentialService.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the service being used in Azure.<br/>
    /// Default Value: speech
    /// </summary>
    public enum AzureCredentialService
    {
        /// <summary>
        /// 
        /// </summary>
        BlobStorage,
        /// <summary>
        /// 
        /// </summary>
        Speech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureCredentialServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureCredentialService value)
        {
            return value switch
            {
                AzureCredentialService.BlobStorage => "blob_storage",
                AzureCredentialService.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureCredentialService? ToEnum(string value)
        {
            return value switch
            {
                "blob_storage" => AzureCredentialService.BlobStorage,
                "speech" => AzureCredentialService.Speech,
                _ => null,
            };
        }
    }
}