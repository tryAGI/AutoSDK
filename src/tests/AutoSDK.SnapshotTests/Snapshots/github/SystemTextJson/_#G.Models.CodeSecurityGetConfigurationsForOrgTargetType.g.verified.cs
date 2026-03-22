//HintName: G.Models.CodeSecurityGetConfigurationsForOrgTargetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum CodeSecurityGetConfigurationsForOrgTargetType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityGetConfigurationsForOrgTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityGetConfigurationsForOrgTargetType value)
        {
            return value switch
            {
                CodeSecurityGetConfigurationsForOrgTargetType.All => "all",
                CodeSecurityGetConfigurationsForOrgTargetType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityGetConfigurationsForOrgTargetType? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecurityGetConfigurationsForOrgTargetType.All,
                "global" => CodeSecurityGetConfigurationsForOrgTargetType.Global,
                _ => null,
            };
        }
    }
}