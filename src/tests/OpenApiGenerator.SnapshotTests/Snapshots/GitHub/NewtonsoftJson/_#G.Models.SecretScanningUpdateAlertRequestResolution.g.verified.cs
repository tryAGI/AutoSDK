//HintName: G.Models.SecretScanningUpdateAlertRequestResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningUpdateAlertRequestResolution
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
    public static class SecretScanningUpdateAlertRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningUpdateAlertRequestResolution value)
        {
            return value switch
            {
                SecretScanningUpdateAlertRequestResolution.FalsePositive => "false_positive",
                SecretScanningUpdateAlertRequestResolution.WontFix => "wont_fix",
                SecretScanningUpdateAlertRequestResolution.Revoked => "revoked",
                SecretScanningUpdateAlertRequestResolution.UsedInTests => "used_in_tests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningUpdateAlertRequestResolution ToEnum(string value)
        {
            return value switch
            {
                "false_positive" => SecretScanningUpdateAlertRequestResolution.FalsePositive,
                "wont_fix" => SecretScanningUpdateAlertRequestResolution.WontFix,
                "revoked" => SecretScanningUpdateAlertRequestResolution.Revoked,
                "used_in_tests" => SecretScanningUpdateAlertRequestResolution.UsedInTests,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}