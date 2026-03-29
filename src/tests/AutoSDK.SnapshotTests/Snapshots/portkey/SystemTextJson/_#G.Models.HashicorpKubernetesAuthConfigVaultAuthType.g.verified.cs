//HintName: G.Models.HashicorpKubernetesAuthConfigVaultAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HashicorpKubernetesAuthConfigVaultAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        Kubernetes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HashicorpKubernetesAuthConfigVaultAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HashicorpKubernetesAuthConfigVaultAuthType value)
        {
            return value switch
            {
                HashicorpKubernetesAuthConfigVaultAuthType.Kubernetes => "kubernetes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HashicorpKubernetesAuthConfigVaultAuthType? ToEnum(string value)
        {
            return value switch
            {
                "kubernetes" => HashicorpKubernetesAuthConfigVaultAuthType.Kubernetes,
                _ => null,
            };
        }
    }
}