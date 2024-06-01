//HintName: G.Models.WebhooksTeamParentNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether team members will receive notifications when their team is @mentioned
    /// </summary>
    public enum WebhooksTeamParentNotificationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        NotificationsEnabled,
        /// <summary>
        /// 
        /// </summary>
        NotificationsDisabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksTeamParentNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeamParentNotificationSetting value)
        {
            return value switch
            {
                WebhooksTeamParentNotificationSetting.NotificationsEnabled => "notifications_enabled",
                WebhooksTeamParentNotificationSetting.NotificationsDisabled => "notifications_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeamParentNotificationSetting ToEnum(string value)
        {
            return value switch
            {
                "notifications_enabled" => WebhooksTeamParentNotificationSetting.NotificationsEnabled,
                "notifications_disabled" => WebhooksTeamParentNotificationSetting.NotificationsDisabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}