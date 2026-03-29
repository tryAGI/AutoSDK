//HintName: G.Models.CreateAzureCredentialDTOService.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the service being used in Azure.<br/>
    /// Default Value: speech
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAzureCredentialDTOService
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blob_storage")]
        BlobStorage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech")]
        Speech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAzureCredentialDTOServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAzureCredentialDTOService value)
        {
            return value switch
            {
                CreateAzureCredentialDTOService.BlobStorage => "blob_storage",
                CreateAzureCredentialDTOService.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAzureCredentialDTOService? ToEnum(string value)
        {
            return value switch
            {
                "blob_storage" => CreateAzureCredentialDTOService.BlobStorage,
                "speech" => CreateAzureCredentialDTOService.Speech,
                _ => null,
            };
        }
    }
}