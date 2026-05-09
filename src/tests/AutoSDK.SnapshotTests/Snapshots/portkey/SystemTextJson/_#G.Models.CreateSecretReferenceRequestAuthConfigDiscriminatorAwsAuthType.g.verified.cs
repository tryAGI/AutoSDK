//HintName: G.Models.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessKey,
        /// <summary>
        /// 
        /// </summary>
        AssumedRole,
        /// <summary>
        /// 
        /// </summary>
        ServiceRole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType value)
        {
            return value switch
            {
                CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType.AccessKey => "accessKey",
                CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType.AssumedRole => "assumedRole",
                CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType.ServiceRole => "serviceRole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType? ToEnum(string value)
        {
            return value switch
            {
                "accessKey" => CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType.AccessKey,
                "assumedRole" => CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType.AssumedRole,
                "serviceRole" => CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType.ServiceRole,
                _ => null,
            };
        }
    }
}