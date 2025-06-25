﻿//HintName: G.Models.WebhooksTeam1NotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether team members will receive notifications when their team is @mentioned
    /// </summary>
    public enum WebhooksTeam1NotificationSetting
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
    public static class WebhooksTeam1NotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeam1NotificationSetting value)
        {
            return value switch
            {
                WebhooksTeam1NotificationSetting.NotificationsEnabled => "notifications_enabled",
                WebhooksTeam1NotificationSetting.NotificationsDisabled => "notifications_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeam1NotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_enabled" => WebhooksTeam1NotificationSetting.NotificationsEnabled,
                "notifications_disabled" => WebhooksTeam1NotificationSetting.NotificationsDisabled,
                _ => null,
            };
        }
    }
}