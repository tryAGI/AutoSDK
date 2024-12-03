//HintName: G.Models.WebhooksIssue2AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2AssigneeType2
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssue2AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2AssigneeType2 value)
        {
            return value switch
            {
                WebhooksIssue2AssigneeType2.Bot => "Bot",
                WebhooksIssue2AssigneeType2.User => "User",
                WebhooksIssue2AssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssue2AssigneeType2.Bot,
                "User" => WebhooksIssue2AssigneeType2.User,
                "Organization" => WebhooksIssue2AssigneeType2.Organization,
                _ => null,
            };
        }
    }
}