//HintName: G.Models.WebhooksTeamNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksTeamNotificationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notifications_disabled")]
        NotificationsDisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notifications_enabled")]
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