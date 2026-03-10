//HintName: G.Models.ConvAIStoredSecretDependenciesAgentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConvAIStoredSecretDependenciesAgentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvAIStoredSecretDependenciesAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvAIStoredSecretDependenciesAgentDiscriminatorType value)
        {
            return value switch
            {
                ConvAIStoredSecretDependenciesAgentDiscriminatorType.Available => "available",
                ConvAIStoredSecretDependenciesAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvAIStoredSecretDependenciesAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => ConvAIStoredSecretDependenciesAgentDiscriminatorType.Available,
                "unknown" => ConvAIStoredSecretDependenciesAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}