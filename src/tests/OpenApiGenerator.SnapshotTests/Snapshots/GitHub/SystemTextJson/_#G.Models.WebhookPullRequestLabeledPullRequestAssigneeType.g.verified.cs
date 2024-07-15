//HintName: G.Models.WebhookPullRequestLabeledPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestAssigneeType
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
    public static class WebhookPullRequestLabeledPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestAssigneeType.User => "User",
                WebhookPullRequestLabeledPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestLabeledPullRequestAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}