//HintName: G.Models.WebhooksTeam1ParentNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether team members will receive notifications when their team is @mentioned
    /// </summary>
    public enum WebhooksTeam1ParentNotificationSetting
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
    public static class WebhooksTeam1ParentNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeam1ParentNotificationSetting value)
        {
            return value switch
            {
                WebhooksTeam1ParentNotificationSetting.NotificationsDisabled => "notifications_disabled",
                WebhooksTeam1ParentNotificationSetting.NotificationsEnabled => "notifications_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeam1ParentNotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_disabled" => WebhooksTeam1ParentNotificationSetting.NotificationsDisabled,
                "notifications_enabled" => WebhooksTeam1ParentNotificationSetting.NotificationsEnabled,
                _ => null,
            };
        }
    }
}