//HintName: G.Models.WebhooksTeamNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksTeamNotificationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        NotificationsDisabled,
        /// <summary>
        /// 
        /// </summary>
        NotificationsEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksTeamNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeamNotificationSetting value)
        {
            return value switch
            {
                WebhooksTeamNotificationSetting.NotificationsDisabled => "notifications_disabled",
                WebhooksTeamNotificationSetting.NotificationsEnabled => "notifications_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeamNotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_disabled" => WebhooksTeamNotificationSetting.NotificationsDisabled,
                "notifications_enabled" => WebhooksTeamNotificationSetting.NotificationsEnabled,
                _ => null,
            };
        }
    }
}