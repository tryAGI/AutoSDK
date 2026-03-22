//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestAssigneeType2
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
    public static class WebhookPullRequestUnassignedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestAssigneeType2.Mannequin => "Mannequin",
                WebhookPullRequestUnassignedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestAssigneeType2.Bot,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestAssigneeType2.Mannequin,
                "Organization" => WebhookPullRequestUnassignedPullRequestAssigneeType2.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestAssigneeType2.User,
                _ => null,
            };
        }
    }
}