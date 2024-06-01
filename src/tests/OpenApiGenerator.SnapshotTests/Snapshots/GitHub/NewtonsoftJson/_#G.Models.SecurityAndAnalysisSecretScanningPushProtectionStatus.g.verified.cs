//HintName: G.Models.SecurityAndAnalysisSecretScanningPushProtectionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAndAnalysisSecretScanningPushProtectionStatus
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
    public static class SecurityAndAnalysisSecretScanningPushProtectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisSecretScanningPushProtectionStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningPushProtectionStatus.Enabled => "enabled",
                SecurityAndAnalysisSecretScanningPushProtectionStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningPushProtectionStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisSecretScanningPushProtectionStatus.Enabled,
                "disabled" => SecurityAndAnalysisSecretScanningPushProtectionStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}