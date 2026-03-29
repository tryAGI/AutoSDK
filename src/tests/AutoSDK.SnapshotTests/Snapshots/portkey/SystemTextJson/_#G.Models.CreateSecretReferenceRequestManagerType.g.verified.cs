//HintName: G.Models.CreateSecretReferenceRequestManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecretReferenceRequestManagerType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsSm,
        /// <summary>
        /// 
        /// </summary>
        AzureKv,
        /// <summary>
        /// 
        /// </summary>
        HashicorpVault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretReferenceRequestManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretReferenceRequestManagerType value)
        {
            return value switch
            {
                CreateSecretReferenceRequestManagerType.AwsSm => "aws_sm",
                CreateSecretReferenceRequestManagerType.AzureKv => "azure_kv",
                CreateSecretReferenceRequestManagerType.HashicorpVault => "hashicorp_vault",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretReferenceRequestManagerType? ToEnum(string value)
        {
            return value switch
            {
                "aws_sm" => CreateSecretReferenceRequestManagerType.AwsSm,
                "azure_kv" => CreateSecretReferenceRequestManagerType.AzureKv,
                "hashicorp_vault" => CreateSecretReferenceRequestManagerType.HashicorpVault,
                _ => null,
            };
        }
    }
}