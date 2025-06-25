﻿//HintName: G.Models.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConvAIStoredSecretDependenciesAgentToolDiscriminatorType
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
    public static class ConvAIStoredSecretDependenciesAgentToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvAIStoredSecretDependenciesAgentToolDiscriminatorType value)
        {
            return value switch
            {
                ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Available => "available",
                ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvAIStoredSecretDependenciesAgentToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Available,
                "unknown" => ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}