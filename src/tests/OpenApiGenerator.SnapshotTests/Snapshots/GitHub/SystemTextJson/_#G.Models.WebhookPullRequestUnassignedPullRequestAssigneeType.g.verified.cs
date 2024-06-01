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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
                WebhookPullRequestUnassignedPullRequestAssigneeType.User => "User",
                WebhookPullRequestUnassignedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestAssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}