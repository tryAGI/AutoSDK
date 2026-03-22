//HintName: G.Models.WebhooksIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssueAssigneeType
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
    public static class WebhooksIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueAssigneeType value)
        {
            return value switch
            {
                WebhooksIssueAssigneeType.Bot => "Bot",
                WebhooksIssueAssigneeType.Mannequin => "Mannequin",
                WebhooksIssueAssigneeType.Organization => "Organization",
                WebhooksIssueAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueAssigneeType.Bot,
                "Mannequin" => WebhooksIssueAssigneeType.Mannequin,
                "Organization" => WebhooksIssueAssigneeType.Organization,
                "User" => WebhooksIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}