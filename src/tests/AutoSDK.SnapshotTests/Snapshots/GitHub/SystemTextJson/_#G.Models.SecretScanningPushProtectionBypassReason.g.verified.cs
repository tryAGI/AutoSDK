//HintName: G.Models.SecretScanningPushProtectionBypassReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for bypassing push protection.
    /// </summary>
    public enum SecretScanningPushProtectionBypassReason
    {
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        UsedInTests,
        /// <summary>
        /// 
        /// </summary>
        WillFixLater,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningPushProtectionBypassReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningPushProtectionBypassReason value)
        {
            return value switch
            {
                SecretScanningPushProtectionBypassReason.FalsePositive => "false_positive",
                SecretScanningPushProtectionBypassReason.UsedInTests => "used_in_tests",
                SecretScanningPushProtectionBypassReason.WillFixLater => "will_fix_later",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningPushProtectionBypassReason? ToEnum(string value)
        {
            return value switch
            {
                "false_positive" => SecretScanningPushProtectionBypassReason.FalsePositive,
                "used_in_tests" => SecretScanningPushProtectionBypassReason.UsedInTests,
                "will_fix_later" => SecretScanningPushProtectionBypassReason.WillFixLater,
                _ => null,
            };
        }
    }
}