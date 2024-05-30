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
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    public static class SecurityAndAnalysisAdvancedSecurityStatusExtensions
    {
        public static string ToValueString(this SecurityAndAnalysisAdvancedSecurityStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisAdvancedSecurityStatus.Enabled => "enabled",
                SecurityAndAnalysisAdvancedSecurityStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisAdvancedSecurityStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisAdvancedSecurityStatus.Enabled,
                "disabled" => SecurityAndAnalysisAdvancedSecurityStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisAdvancedSecurityStatus ToEnum(int value)
        {
            return value switch
            {
                0 => SecurityAndAnalysisAdvancedSecurityStatus.Enabled,
                1 => SecurityAndAnalysisAdvancedSecurityStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}