//HintName: G.Models.WebhookPullRequestAssignedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestAssigneesType
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
    public static class WebhookPullRequestAssignedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestAssigneesType.User => "User",
                WebhookPullRequestAssignedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestAssignedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestAssignedPullRequestAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}