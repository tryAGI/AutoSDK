//HintName: G.Models.WebhooksPullRequest5AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5AssigneeType2
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
    public static class WebhooksPullRequest5AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5AssigneeType2 value)
        {
            return value switch
            {
                WebhooksPullRequest5AssigneeType2.Bot => "Bot",
                WebhooksPullRequest5AssigneeType2.Mannequin => "Mannequin",
                WebhooksPullRequest5AssigneeType2.Organization => "Organization",
                WebhooksPullRequest5AssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5AssigneeType2.Bot,
                "Mannequin" => WebhooksPullRequest5AssigneeType2.Mannequin,
                "Organization" => WebhooksPullRequest5AssigneeType2.Organization,
                "User" => WebhooksPullRequest5AssigneeType2.User,
                _ => null,
            };
        }
    }
}