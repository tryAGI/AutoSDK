//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestAssigneesType
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
    public static class WebhookPullRequestUnassignedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestAssigneesType.User => "User",
                WebhookPullRequestUnassignedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}