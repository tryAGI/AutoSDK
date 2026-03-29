//HintName: G.Models.UpdateAzureCredentialDTOService.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the service being used in Azure.<br/>
    /// Default Value: speech
    /// </summary>
    public enum UpdateAzureCredentialDTOService
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
    public static class UpdateAzureCredentialDTOServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAzureCredentialDTOService value)
        {
            return value switch
            {
                UpdateAzureCredentialDTOService.BlobStorage => "blob_storage",
                UpdateAzureCredentialDTOService.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAzureCredentialDTOService? ToEnum(string value)
        {
            return value switch
            {
                "blob_storage" => UpdateAzureCredentialDTOService.BlobStorage,
                "speech" => UpdateAzureCredentialDTOService.Speech,
                _ => null,
            };
        }
    }
}