//HintName: G.Models.TeamsCreateRequestNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The notification setting the team has chosen. The options are:  <br/>
    ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
    ///  * `notifications_disabled` - no one receives notifications.  <br/>
    /// Default: `notifications_enabled`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsCreateRequestNotificationSetting
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
        public static TeamsCreateRequestNotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_enabled" => TeamsCreateRequestNotificationSetting.NotificationsEnabled,
                "notifications_disabled" => TeamsCreateRequestNotificationSetting.NotificationsDisabled,
                _ => null,
            };
        }
    }
}