//HintName: G.Models.WebhooksTeamParentNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether team members will receive notifications when their team is @mentioned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksTeamParentNotificationSetting
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
}