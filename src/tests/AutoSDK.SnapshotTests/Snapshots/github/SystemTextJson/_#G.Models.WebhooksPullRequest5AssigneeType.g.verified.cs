//HintName: G.Models.WebhooksPullRequest5AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5AssigneeType
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
    public static class WebhooksPullRequest5AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5AssigneeType value)
        {
            return value switch
            {
                WebhooksPullRequest5AssigneeType.Bot => "Bot",
                WebhooksPullRequest5AssigneeType.Mannequin => "Mannequin",
                WebhooksPullRequest5AssigneeType.Organization => "Organization",
                WebhooksPullRequest5AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5AssigneeType.Bot,
                "Mannequin" => WebhooksPullRequest5AssigneeType.Mannequin,
                "Organization" => WebhooksPullRequest5AssigneeType.Organization,
                "User" => WebhooksPullRequest5AssigneeType.User,
                _ => null,
            };
        }
    }
}