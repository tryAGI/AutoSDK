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
}