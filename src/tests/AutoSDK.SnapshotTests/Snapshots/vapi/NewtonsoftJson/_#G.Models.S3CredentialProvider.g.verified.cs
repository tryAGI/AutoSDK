//HintName: G.Models.S3CredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Credential provider. Only allowed value is s3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum S3CredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s3")]
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class S3CredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this S3CredentialProvider value)
        {
            return value switch
            {
                S3CredentialProvider.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static S3CredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "s3" => S3CredentialProvider.S3,
                _ => null,
            };
        }
    }
}