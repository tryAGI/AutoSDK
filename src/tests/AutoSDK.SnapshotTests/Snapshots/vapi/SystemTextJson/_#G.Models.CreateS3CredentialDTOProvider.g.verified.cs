//HintName: G.Models.CreateS3CredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Credential provider. Only allowed value is s3
    /// </summary>
    public enum CreateS3CredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateS3CredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateS3CredentialDTOProvider value)
        {
            return value switch
            {
                CreateS3CredentialDTOProvider.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateS3CredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "s3" => CreateS3CredentialDTOProvider.S3,
                _ => null,
            };
        }
    }
}