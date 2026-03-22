//HintName: G.Models.WebhookPullRequestUnassignedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnassignedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestUnassignedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestUnassignedPullRequestUserType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}