//HintName: G.Models.SecretReferenceDetailResponseManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretReferenceDetailResponseManagerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aws_sm")]
        AwsSm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure_kv")]
        AzureKv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hashicorp_vault")]
        HashicorpVault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretReferenceDetailResponseManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretReferenceDetailResponseManagerType value)
        {
            return value switch
            {
                SecretReferenceDetailResponseManagerType.AwsSm => "aws_sm",
                SecretReferenceDetailResponseManagerType.AzureKv => "azure_kv",
                SecretReferenceDetailResponseManagerType.HashicorpVault => "hashicorp_vault",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretReferenceDetailResponseManagerType? ToEnum(string value)
        {
            return value switch
            {
                "aws_sm" => SecretReferenceDetailResponseManagerType.AwsSm,
                "azure_kv" => SecretReferenceDetailResponseManagerType.AzureKv,
                "hashicorp_vault" => SecretReferenceDetailResponseManagerType.HashicorpVault,
                _ => null,
            };
        }
    }
}