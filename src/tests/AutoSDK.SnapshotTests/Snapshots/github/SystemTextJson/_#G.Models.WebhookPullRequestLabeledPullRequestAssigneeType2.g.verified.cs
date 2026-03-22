//HintName: G.Models.WebhookPullRequestLabeledPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestAssigneeType2
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
    public static class WebhookPullRequestLabeledPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestAssigneeType2.Mannequin => "Mannequin",
                WebhookPullRequestLabeledPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestAssigneeType2.Bot,
                "Mannequin" => WebhookPullRequestLabeledPullRequestAssigneeType2.Mannequin,
                "Organization" => WebhookPullRequestLabeledPullRequestAssigneeType2.Organization,
                "User" => WebhookPullRequestLabeledPullRequestAssigneeType2.User,
                _ => null,
            };
        }
    }
}