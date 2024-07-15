//HintName: G.Models.WebhookCodeScanningAlertClosedByUserAlertDismissedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertClosedByUserAlertDismissedByType
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
    public static class WebhookCodeScanningAlertClosedByUserAlertDismissedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertClosedByUserAlertDismissedByType value)
        {
            return value switch
            {
                WebhookCodeScanningAlertClosedByUserAlertDismissedByType.Bot => "Bot",
                WebhookCodeScanningAlertClosedByUserAlertDismissedByType.User => "User",
                WebhookCodeScanningAlertClosedByUserAlertDismissedByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertClosedByUserAlertDismissedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCodeScanningAlertClosedByUserAlertDismissedByType.Bot,
                "User" => WebhookCodeScanningAlertClosedByUserAlertDismissedByType.User,
                "Organization" => WebhookCodeScanningAlertClosedByUserAlertDismissedByType.Organization,
                _ => null,
            };
        }
    }
}