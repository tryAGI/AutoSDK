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

    public static class SecurityAndAnalysisSecretScanningPushProtectionStatusExtensions
    {
        public static string ToValueString(this SecurityAndAnalysisSecretScanningPushProtectionStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningPushProtectionStatus.Enabled => "enabled",
                SecurityAndAnalysisSecretScanningPushProtectionStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisSecretScanningPushProtectionStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisSecretScanningPushProtectionStatus.Enabled,
                "disabled" => SecurityAndAnalysisSecretScanningPushProtectionStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SecurityAndAnalysisSecretScanningPushProtectionStatus ToEnum(int value)
        {
            return value switch
            {
                0 => SecurityAndAnalysisSecretScanningPushProtectionStatus.Enabled,
                1 => SecurityAndAnalysisSecretScanningPushProtectionStatus.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}