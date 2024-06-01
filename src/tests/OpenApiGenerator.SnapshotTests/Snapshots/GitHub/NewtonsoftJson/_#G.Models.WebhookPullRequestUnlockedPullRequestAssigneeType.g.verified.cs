//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlockedPullRequestAssigneeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnlockedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestAssigneeType.User => "User",
                WebhookPullRequestUnlockedPullRequestAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestAssigneeType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}