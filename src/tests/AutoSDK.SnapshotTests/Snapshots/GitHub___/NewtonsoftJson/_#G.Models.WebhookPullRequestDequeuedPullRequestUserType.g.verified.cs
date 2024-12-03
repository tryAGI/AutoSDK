//HintName: G.Models.WebhookPullRequestDequeuedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedPullRequestUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestDequeuedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestUserType.User => "User",
                WebhookPullRequestDequeuedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestUserType.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestUserType.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestDequeuedPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}