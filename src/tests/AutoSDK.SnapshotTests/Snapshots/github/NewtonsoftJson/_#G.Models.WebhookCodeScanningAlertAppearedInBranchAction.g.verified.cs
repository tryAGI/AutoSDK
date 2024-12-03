//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertAppearedInBranchAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="appeared_in_branch")]
        AppearedInBranch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertAppearedInBranchActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAction value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAction.AppearedInBranch => "appeared_in_branch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertAppearedInBranchAction? ToEnum(string value)
        {
            return value switch
            {
                "appeared_in_branch" => WebhookCodeScanningAlertAppearedInBranchAction.AppearedInBranch,
                _ => null,
            };
        }
    }
}