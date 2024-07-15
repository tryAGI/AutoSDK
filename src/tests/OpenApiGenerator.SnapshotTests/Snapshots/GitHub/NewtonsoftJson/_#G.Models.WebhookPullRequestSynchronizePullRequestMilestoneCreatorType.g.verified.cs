//HintName: G.Models.WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestMilestoneCreatorType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}