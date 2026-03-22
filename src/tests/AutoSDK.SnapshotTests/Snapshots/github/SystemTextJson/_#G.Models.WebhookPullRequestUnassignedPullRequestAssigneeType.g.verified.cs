//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestAssigneeType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnassignedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestUnassignedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestUnassignedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}