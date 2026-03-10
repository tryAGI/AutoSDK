//HintName: G.Models.ConvAIStoredSecretDependenciesAgentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConvAIStoredSecretDependenciesAgentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="available")]
        Available,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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