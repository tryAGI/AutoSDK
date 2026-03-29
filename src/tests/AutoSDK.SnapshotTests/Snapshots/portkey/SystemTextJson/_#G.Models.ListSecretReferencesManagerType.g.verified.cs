//HintName: G.Models.ListSecretReferencesManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListSecretReferencesManagerType
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
    public static class ListSecretReferencesManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSecretReferencesManagerType value)
        {
            return value switch
            {
                ListSecretReferencesManagerType.AwsSm => "aws_sm",
                ListSecretReferencesManagerType.AzureKv => "azure_kv",
                ListSecretReferencesManagerType.HashicorpVault => "hashicorp_vault",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSecretReferencesManagerType? ToEnum(string value)
        {
            return value switch
            {
                "aws_sm" => ListSecretReferencesManagerType.AwsSm,
                "azure_kv" => ListSecretReferencesManagerType.AzureKv,
                "hashicorp_vault" => ListSecretReferencesManagerType.HashicorpVault,
                _ => null,
            };
        }
    }
}