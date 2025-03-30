//HintName: G.Models.DependentAvailableAgentIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: available
    /// </summary>
    public enum DependentAvailableAgentIdentifierType
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependentAvailableAgentIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentAvailableAgentIdentifierType value)
        {
            return value switch
            {
                DependentAvailableAgentIdentifierType.Available => "available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentAvailableAgentIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "available" => DependentAvailableAgentIdentifierType.Available,
                _ => null,
            };
        }
    }
}