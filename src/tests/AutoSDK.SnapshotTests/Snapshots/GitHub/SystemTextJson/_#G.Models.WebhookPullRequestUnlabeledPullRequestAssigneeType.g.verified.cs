//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestAssigneeType
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
    public static class WebhookPullRequestUnlabeledPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestAssigneeType.User => "User",
                WebhookPullRequestUnlabeledPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}