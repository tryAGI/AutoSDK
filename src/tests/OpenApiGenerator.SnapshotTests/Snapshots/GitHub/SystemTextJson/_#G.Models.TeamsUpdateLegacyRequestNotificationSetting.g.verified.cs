//HintName: G.Models.TeamsUpdateLegacyRequestNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: 
    ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  
    ///  * `notifications_disabled` - no one receives notifications.
    /// </summary>
    public enum TeamsUpdateLegacyRequestNotificationSetting
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
    public static class TeamsUpdateLegacyRequestNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsUpdateLegacyRequestNotificationSetting value)
        {
            return value switch
            {
                TeamsUpdateLegacyRequestNotificationSetting.NotificationsEnabled => "notifications_enabled",
                TeamsUpdateLegacyRequestNotificationSetting.NotificationsDisabled => "notifications_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsUpdateLegacyRequestNotificationSetting ToEnum(string value)
        {
            return value switch
            {
                "notifications_enabled" => TeamsUpdateLegacyRequestNotificationSetting.NotificationsEnabled,
                "notifications_disabled" => TeamsUpdateLegacyRequestNotificationSetting.NotificationsDisabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}