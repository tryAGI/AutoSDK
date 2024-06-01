//HintName: G.Models.TeamFullNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The notification setting the team has set
    /// <br/>Example: notifications_enabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamFullNotificationSetting
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
    public static class TeamFullNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamFullNotificationSetting value)
        {
            return value switch
            {
                TeamFullNotificationSetting.NotificationsEnabled => "notifications_enabled",
                TeamFullNotificationSetting.NotificationsDisabled => "notifications_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamFullNotificationSetting ToEnum(string value)
        {
            return value switch
            {
                "notifications_enabled" => TeamFullNotificationSetting.NotificationsEnabled,
                "notifications_disabled" => TeamFullNotificationSetting.NotificationsDisabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}