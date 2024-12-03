//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestUserType
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
    public static class WebhookPullRequestUnlabeledPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestUserType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestUserType.User => "User",
                WebhookPullRequestUnlabeledPullRequestUserType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestUserType.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestUserType.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}