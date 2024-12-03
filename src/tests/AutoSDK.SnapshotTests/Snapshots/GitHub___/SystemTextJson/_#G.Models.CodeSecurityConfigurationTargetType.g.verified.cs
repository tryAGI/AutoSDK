//HintName: G.Models.CodeSecurityConfigurationTargetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the code security configuration.
    /// </summary>
    public enum CodeSecurityConfigurationTargetType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationTargetType value)
        {
            return value switch
            {
                CodeSecurityConfigurationTargetType.Global => "global",
                CodeSecurityConfigurationTargetType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationTargetType? ToEnum(string value)
        {
            return value switch
            {
                "global" => CodeSecurityConfigurationTargetType.Global,
                "organization" => CodeSecurityConfigurationTargetType.Organization,
                _ => null,
            };
        }
    }
}