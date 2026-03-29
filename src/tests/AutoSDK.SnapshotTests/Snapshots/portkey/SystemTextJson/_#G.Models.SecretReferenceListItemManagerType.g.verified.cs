//HintName: G.Models.SecretReferenceListItemManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretReferenceListItemManagerType
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
    public static class SecretReferenceListItemManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretReferenceListItemManagerType value)
        {
            return value switch
            {
                SecretReferenceListItemManagerType.AwsSm => "aws_sm",
                SecretReferenceListItemManagerType.AzureKv => "azure_kv",
                SecretReferenceListItemManagerType.HashicorpVault => "hashicorp_vault",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretReferenceListItemManagerType? ToEnum(string value)
        {
            return value switch
            {
                "aws_sm" => SecretReferenceListItemManagerType.AwsSm,
                "azure_kv" => SecretReferenceListItemManagerType.AzureKv,
                "hashicorp_vault" => SecretReferenceListItemManagerType.HashicorpVault,
                _ => null,
            };
        }
    }
}