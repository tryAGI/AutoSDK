//HintName: G.Models.WebhooksIssue2AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2AssigneeType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhooksIssue2AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2AssigneeType value)
        {
            return value switch
            {
                WebhooksIssue2AssigneeType.Bot => "Bot",
                WebhooksIssue2AssigneeType.Organization => "Organization",
                WebhooksIssue2AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssue2AssigneeType.Bot,
                "Organization" => WebhooksIssue2AssigneeType.Organization,
                "User" => WebhooksIssue2AssigneeType.User,
                _ => null,
            };
        }
    }
}