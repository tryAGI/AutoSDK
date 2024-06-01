//HintName: G.Models.SecretScanningAlertWebhookResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for resolving the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningAlertWebhookResolution
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pattern_deleted")]
        PatternDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pattern_edited")]
        PatternEdited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningAlertWebhookResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertWebhookResolution value)
        {
            return value switch
            {
                SecretScanningAlertWebhookResolution.FalsePositive => "false_positive",
                SecretScanningAlertWebhookResolution.WontFix => "wont_fix",
                SecretScanningAlertWebhookResolution.Revoked => "revoked",
                SecretScanningAlertWebhookResolution.UsedInTests => "used_in_tests",
                SecretScanningAlertWebhookResolution.PatternDeleted => "pattern_deleted",
                SecretScanningAlertWebhookResolution.PatternEdited => "pattern_edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertWebhookResolution ToEnum(string value)
        {
            return value switch
            {
                "false_positive" => SecretScanningAlertWebhookResolution.FalsePositive,
                "wont_fix" => SecretScanningAlertWebhookResolution.WontFix,
                "revoked" => SecretScanningAlertWebhookResolution.Revoked,
                "used_in_tests" => SecretScanningAlertWebhookResolution.UsedInTests,
                "pattern_deleted" => SecretScanningAlertWebhookResolution.PatternDeleted,
                "pattern_edited" => SecretScanningAlertWebhookResolution.PatternEdited,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}