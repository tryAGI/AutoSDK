//HintName: G.Models.TeamsUpdateInOrgRequestNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: <br/>
    ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
    ///  * `notifications_disabled` - no one receives notifications.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsUpdateInOrgRequestNotificationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notifications_enabled")]
        NotificationsEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notifications_disabled")]
        NotificationsDisabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsUpdateInOrgRequestNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsUpdateInOrgRequestNotificationSetting value)
        {
            return value switch
            {
                TeamsUpdateInOrgRequestNotificationSetting.NotificationsEnabled => "notifications_enabled",
                TeamsUpdateInOrgRequestNotificationSetting.NotificationsDisabled => "notifications_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsUpdateInOrgRequestNotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_enabled" => TeamsUpdateInOrgRequestNotificationSetting.NotificationsEnabled,
                "notifications_disabled" => TeamsUpdateInOrgRequestNotificationSetting.NotificationsDisabled,
                _ => null,
            };
        }
    }
}