//HintName: G.Models.WebhookPullRequestLabeledPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestUserType
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
    public static class WebhookPullRequestLabeledPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestUserType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestLabeledPullRequestUserType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestLabeledPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestLabeledPullRequestUserType.Organization,
                "User" => WebhookPullRequestLabeledPullRequestUserType.User,
                _ => null,
            };
        }
    }
}