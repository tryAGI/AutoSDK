//HintName: G.Models.WebhookPullRequestAssignedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestUserType
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
    public static class WebhookPullRequestAssignedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestUserType.User => "User",
                WebhookPullRequestAssignedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestUserType.Bot,
                "User" => WebhookPullRequestAssignedPullRequestUserType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestAssignedPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}