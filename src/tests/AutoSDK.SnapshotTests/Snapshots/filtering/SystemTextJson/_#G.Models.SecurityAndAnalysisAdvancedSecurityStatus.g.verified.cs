//HintName: G.Models.SecurityAndAnalysisAdvancedSecurityStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAndAnalysisAdvancedSecurityStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAndAnalysisAdvancedSecurityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisAdvancedSecurityStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisAdvancedSecurityStatus.Disabled => "disabled",
                SecurityAndAnalysisAdvancedSecurityStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisAdvancedSecurityStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecurityAndAnalysisAdvancedSecurityStatus.Disabled,
                "enabled" => SecurityAndAnalysisAdvancedSecurityStatus.Enabled,
                _ => null,
            };
        }
    }
}