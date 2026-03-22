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
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
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
                SecurityAndAnalysisSecretScanningPushProtectionStatus.Disabled => "disabled",
                SecurityAndAnalysisSecretScanningPushProtectionStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningPushProtectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecurityAndAnalysisSecretScanningPushProtectionStatus.Disabled,
                "enabled" => SecurityAndAnalysisSecretScanningPushProtectionStatus.Enabled,
                _ => null,
            };
        }
    }
}