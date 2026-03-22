//HintName: G.Models.SecretScanningAlertResolutionWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for resolving the alert.
    /// </summary>
    public enum SecretScanningAlertResolutionWebhook
    {
        /// <summary>
        /// 
        /// </summary>
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        PatternDeleted,
        /// <summary>
        /// 
        /// </summary>
        PatternEdited,
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
                SecretScanningAlertResolutionWebhook.PatternDeleted => "pattern_deleted",
                SecretScanningAlertResolutionWebhook.PatternEdited => "pattern_edited",
                SecretScanningAlertResolutionWebhook.Revoked => "revoked",
                SecretScanningAlertResolutionWebhook.UsedInTests => "used_in_tests",
                SecretScanningAlertResolutionWebhook.WontFix => "wont_fix",
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
                "pattern_deleted" => SecretScanningAlertResolutionWebhook.PatternDeleted,
                "pattern_edited" => SecretScanningAlertResolutionWebhook.PatternEdited,
                "revoked" => SecretScanningAlertResolutionWebhook.Revoked,
                "used_in_tests" => SecretScanningAlertResolutionWebhook.UsedInTests,
                "wont_fix" => SecretScanningAlertResolutionWebhook.WontFix,
                _ => null,
            };
        }
    }
}