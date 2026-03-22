//HintName: G.Models.SecretScanningAlertResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
    /// </summary>
    public enum SecretScanningAlertResolution
    {
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        Revoked,
        /// <summary>
        /// 
        /// </summary>
        UsedInTests,
        /// <summary>
        /// 
        /// </summary>
        WontFix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningAlertResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertResolution value)
        {
            return value switch
            {
                SecretScanningAlertResolution.FalsePositive => "false_positive",
                SecretScanningAlertResolution.Revoked => "revoked",
                SecretScanningAlertResolution.UsedInTests => "used_in_tests",
                SecretScanningAlertResolution.WontFix => "wont_fix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertResolution? ToEnum(string value)
        {
            return value switch
            {
                "false_positive" => SecretScanningAlertResolution.FalsePositive,
                "revoked" => SecretScanningAlertResolution.Revoked,
                "used_in_tests" => SecretScanningAlertResolution.UsedInTests,
                "wont_fix" => SecretScanningAlertResolution.WontFix,
                _ => null,
            };
        }
    }
}