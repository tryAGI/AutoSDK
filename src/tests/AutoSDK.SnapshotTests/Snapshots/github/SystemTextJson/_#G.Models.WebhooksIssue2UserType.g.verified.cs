//HintName: G.Models.WebhooksIssue2UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2UserType
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
    public static class WebhooksIssue2UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2UserType value)
        {
            return value switch
            {
                WebhooksIssue2UserType.Bot => "Bot",
                WebhooksIssue2UserType.Organization => "Organization",
                WebhooksIssue2UserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssue2UserType.Bot,
                "Organization" => WebhooksIssue2UserType.Organization,
                "User" => WebhooksIssue2UserType.User,
                _ => null,
            };
        }
    }
}