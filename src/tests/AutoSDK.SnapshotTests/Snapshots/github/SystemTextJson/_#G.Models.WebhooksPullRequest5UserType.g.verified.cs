//HintName: G.Models.WebhooksPullRequest5UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5UserType
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
    public static class WebhooksPullRequest5UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5UserType value)
        {
            return value switch
            {
                WebhooksPullRequest5UserType.Bot => "Bot",
                WebhooksPullRequest5UserType.Mannequin => "Mannequin",
                WebhooksPullRequest5UserType.Organization => "Organization",
                WebhooksPullRequest5UserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5UserType.Bot,
                "Mannequin" => WebhooksPullRequest5UserType.Mannequin,
                "Organization" => WebhooksPullRequest5UserType.Organization,
                "User" => WebhooksPullRequest5UserType.User,
                _ => null,
            };
        }
    }
}