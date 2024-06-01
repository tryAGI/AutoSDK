//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}