//HintName: G.Models.WebhookCodeScanningAlertFixedAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for dismissing or closing the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertFixedAlertDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="false positive")]
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="won't fix")]
        WontFix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="used in tests")]
        UsedInTests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertFixedAlertDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertFixedAlertDismissedReason value)
        {
            return value switch
            {
                WebhookCodeScanningAlertFixedAlertDismissedReason.FalsePositive => "false positive",
                WebhookCodeScanningAlertFixedAlertDismissedReason.WontFix => "won't fix",
                WebhookCodeScanningAlertFixedAlertDismissedReason.UsedInTests => "used in tests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertFixedAlertDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "false positive" => WebhookCodeScanningAlertFixedAlertDismissedReason.FalsePositive,
                "won't fix" => WebhookCodeScanningAlertFixedAlertDismissedReason.WontFix,
                "used in tests" => WebhookCodeScanningAlertFixedAlertDismissedReason.UsedInTests,
                _ => null,
            };
        }
    }
}