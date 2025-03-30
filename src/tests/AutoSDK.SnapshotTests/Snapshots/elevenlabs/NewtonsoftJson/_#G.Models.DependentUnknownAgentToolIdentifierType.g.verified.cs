//HintName: G.Models.DependentUnknownAgentToolIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: unknown
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependentUnknownAgentToolIdentifierType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependentUnknownAgentToolIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentUnknownAgentToolIdentifierType value)
        {
            return value switch
            {
                DependentUnknownAgentToolIdentifierType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentUnknownAgentToolIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => DependentUnknownAgentToolIdentifierType.Unknown,
                _ => null,
            };
        }
    }
}