//HintName: G.Models.OrganizationSecretScanningAlertResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
    /// </summary>
    public enum OrganizationSecretScanningAlertResolution
    {
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        WontFix,
        /// <summary>
        /// 
        /// </summary>
        Revoked,
        /// <summary>
        /// 
        /// </summary>
        UsedInTests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSecretScanningAlertResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSecretScanningAlertResolution value)
        {
            return value switch
            {
                OrganizationSecretScanningAlertResolution.FalsePositive => "false_positive",
                OrganizationSecretScanningAlertResolution.WontFix => "wont_fix",
                OrganizationSecretScanningAlertResolution.Revoked => "revoked",
                OrganizationSecretScanningAlertResolution.UsedInTests => "used_in_tests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSecretScanningAlertResolution ToEnum(string value)
        {
            return value switch
            {
                "false_positive" => OrganizationSecretScanningAlertResolution.FalsePositive,
                "wont_fix" => OrganizationSecretScanningAlertResolution.WontFix,
                "revoked" => OrganizationSecretScanningAlertResolution.Revoked,
                "used_in_tests" => OrganizationSecretScanningAlertResolution.UsedInTests,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}