//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertAppearedInBranchAlertDismissedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType.Bot => "Bot",
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType.User => "User",
                WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType.Bot,
                "User" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType.User,
                "Organization" => WebhookCodeScanningAlertAppearedInBranchAlertDismissedByType.Organization,
                _ => null,
            };
        }
    }
}