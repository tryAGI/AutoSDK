//HintName: G.Models.DependentUnknownAgentIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: unknown
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependentUnknownAgentIdentifierType
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
    public static class DependentUnknownAgentIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentUnknownAgentIdentifierType value)
        {
            return value switch
            {
                DependentUnknownAgentIdentifierType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentUnknownAgentIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => DependentUnknownAgentIdentifierType.Unknown,
                _ => null,
            };
        }
    }
}