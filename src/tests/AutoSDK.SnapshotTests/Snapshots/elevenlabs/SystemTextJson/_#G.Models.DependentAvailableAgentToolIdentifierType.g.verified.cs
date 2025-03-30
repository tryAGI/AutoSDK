//HintName: G.Models.DependentAvailableAgentToolIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: available
    /// </summary>
    public enum DependentAvailableAgentToolIdentifierType
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependentAvailableAgentToolIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentAvailableAgentToolIdentifierType value)
        {
            return value switch
            {
                DependentAvailableAgentToolIdentifierType.Available => "available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentAvailableAgentToolIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "available" => DependentAvailableAgentToolIdentifierType.Available,
                _ => null,
            };
        }
    }
}