//HintName: G.Models.WebhooksIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssueAssigneesType
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
    public static class WebhooksIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueAssigneesType value)
        {
            return value switch
            {
                WebhooksIssueAssigneesType.Bot => "Bot",
                WebhooksIssueAssigneesType.User => "User",
                WebhooksIssueAssigneesType.Organization => "Organization",
                WebhooksIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueAssigneesType.Bot,
                "User" => WebhooksIssueAssigneesType.User,
                "Organization" => WebhooksIssueAssigneesType.Organization,
                "Mannequin" => WebhooksIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}