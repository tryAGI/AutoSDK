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
                WebhookPullRequestUnlabeledPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestUnlabeledPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestAssigneeType.User => "User",
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
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestUnlabeledPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestUnlabeledPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}