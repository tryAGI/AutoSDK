//HintName: G.Models.SecretScanningAlertResolutionWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for resolving the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningAlertResolutionWebhook
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
    public static class SecretScanningAlertResolutionWebhookExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertResolutionWebhook value)
        {
            return value switch
            {
                SecretScanningAlertResolutionWebhook.FalsePositive => "false_positive",
                SecretScanningAlertResolutionWebhook.WontFix => "wont_fix",
                SecretScanningAlertResolutionWebhook.Revoked => "revoked",
                SecretScanningAlertResolutionWebhook.UsedInTests => "used_in_tests",
                SecretScanningAlertResolutionWebhook.PatternDeleted => "pattern_deleted",
                SecretScanningAlertResolutionWebhook.PatternEdited => "pattern_edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertResolutionWebhook? ToEnum(string value)
        {
            return value switch
            {
                "false_positive" => SecretScanningAlertResolutionWebhook.FalsePositive,
                "wont_fix" => SecretScanningAlertResolutionWebhook.WontFix,
                "revoked" => SecretScanningAlertResolutionWebhook.Revoked,
                "used_in_tests" => SecretScanningAlertResolutionWebhook.UsedInTests,
                "pattern_deleted" => SecretScanningAlertResolutionWebhook.PatternDeleted,
                "pattern_edited" => SecretScanningAlertResolutionWebhook.PatternEdited,
                _ => null,
            };
        }
    }
}