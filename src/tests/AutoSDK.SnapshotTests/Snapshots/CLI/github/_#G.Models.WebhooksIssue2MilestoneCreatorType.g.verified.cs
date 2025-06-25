//HintName: G.Models.WebhooksIssue2MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2MilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssue2MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2MilestoneCreatorType value)
        {
            return value switch
            {
                WebhooksIssue2MilestoneCreatorType.Bot => "Bot",
                WebhooksIssue2MilestoneCreatorType.User => "User",
                WebhooksIssue2MilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssue2MilestoneCreatorType.Bot,
                "User" => WebhooksIssue2MilestoneCreatorType.User,
                "Organization" => WebhooksIssue2MilestoneCreatorType.Organization,
                _ => null,
            };
        }
    }
}