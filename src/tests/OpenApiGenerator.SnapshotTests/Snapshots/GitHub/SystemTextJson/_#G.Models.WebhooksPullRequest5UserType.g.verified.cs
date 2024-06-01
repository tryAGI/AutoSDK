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
                WebhooksPullRequest5UserType.User => "User",
                WebhooksPullRequest5UserType.Organization => "Organization",
                WebhooksPullRequest5UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5UserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5UserType.Bot,
                "User" => WebhooksPullRequest5UserType.User,
                "Organization" => WebhooksPullRequest5UserType.Organization,
                "Mannequin" => WebhooksPullRequest5UserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}