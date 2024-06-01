//HintName: G.Models.CodeScanningAlertItemsDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertItemsDismissedReason
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
    public static class CodeScanningAlertItemsDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertItemsDismissedReason value)
        {
            return value switch
            {
                CodeScanningAlertItemsDismissedReason.FalsePositive => "false positive",
                CodeScanningAlertItemsDismissedReason.WontFix => "won't fix",
                CodeScanningAlertItemsDismissedReason.UsedInTests => "used in tests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertItemsDismissedReason ToEnum(string value)
        {
            return value switch
            {
                "false positive" => CodeScanningAlertItemsDismissedReason.FalsePositive,
                "won't fix" => CodeScanningAlertItemsDismissedReason.WontFix,
                "used in tests" => CodeScanningAlertItemsDismissedReason.UsedInTests,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}