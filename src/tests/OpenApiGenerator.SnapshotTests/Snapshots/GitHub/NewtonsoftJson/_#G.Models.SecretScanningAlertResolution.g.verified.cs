//HintName: G.Models.SecretScanningAlertResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningAlertResolution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="false_positive")]
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wont_fix")]
        WontFix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="revoked")]
        Revoked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="used_in_tests")]
        UsedInTests,
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
                SecretScanningAlertResolution.WontFix => "wont_fix",
                SecretScanningAlertResolution.Revoked => "revoked",
                SecretScanningAlertResolution.UsedInTests => "used_in_tests",
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
                "wont_fix" => SecretScanningAlertResolution.WontFix,
                "revoked" => SecretScanningAlertResolution.Revoked,
                "used_in_tests" => SecretScanningAlertResolution.UsedInTests,
                _ => null,
            };
        }
    }
}