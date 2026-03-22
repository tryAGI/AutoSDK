//HintName: G.Models.WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnassignedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}