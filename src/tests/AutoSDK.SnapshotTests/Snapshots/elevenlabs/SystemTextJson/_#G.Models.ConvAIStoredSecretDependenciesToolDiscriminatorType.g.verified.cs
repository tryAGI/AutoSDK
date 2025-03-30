//HintName: G.Models.ConvAIStoredSecretDependenciesToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConvAIStoredSecretDependenciesToolDiscriminatorType
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
    public static class ConvAIStoredSecretDependenciesToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvAIStoredSecretDependenciesToolDiscriminatorType value)
        {
            return value switch
            {
                ConvAIStoredSecretDependenciesToolDiscriminatorType.Available => "available",
                ConvAIStoredSecretDependenciesToolDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvAIStoredSecretDependenciesToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => ConvAIStoredSecretDependenciesToolDiscriminatorType.Available,
                "unknown" => ConvAIStoredSecretDependenciesToolDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}