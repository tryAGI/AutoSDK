//HintName: G.Models.TeamsCreateRequestNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The notification setting the team has chosen. The options are:  
    ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  
    ///  * `notifications_disabled` - no one receives notifications.  
    /// Default: `notifications_enabled`
    /// </summary>
    public enum TeamsCreateRequestNotificationSetting
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
    public static class TeamsCreateRequestNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsCreateRequestNotificationSetting value)
        {
            return value switch
            {
                TeamsCreateRequestNotificationSetting.NotificationsEnabled => "notifications_enabled",
                TeamsCreateRequestNotificationSetting.NotificationsDisabled => "notifications_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsCreateRequestNotificationSetting ToEnum(string value)
        {
            return value switch
            {
                "notifications_enabled" => TeamsCreateRequestNotificationSetting.NotificationsEnabled,
                "notifications_disabled" => TeamsCreateRequestNotificationSetting.NotificationsDisabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}