//HintName: G.Models.SecurityAndAnalysisAdvancedSecurityStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAndAnalysisAdvancedSecurityStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
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
                SecurityAndAnalysisAdvancedSecurityStatus.Enabled => "enabled",
                SecurityAndAnalysisAdvancedSecurityStatus.Disabled => "disabled",
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
                "enabled" => SecurityAndAnalysisAdvancedSecurityStatus.Enabled,
                "disabled" => SecurityAndAnalysisAdvancedSecurityStatus.Disabled,
                _ => null,
            };
        }
    }
}