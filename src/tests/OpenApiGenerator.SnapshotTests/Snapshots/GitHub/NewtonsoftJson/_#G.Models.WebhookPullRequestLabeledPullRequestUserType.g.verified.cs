//HintName: G.Models.WebhookPullRequestLabeledPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestUserType
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
    public static class WebhookPullRequestLabeledPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestUserType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestUserType.User => "User",
                WebhookPullRequestLabeledPullRequestUserType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestUserType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestUserType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestLabeledPullRequestUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}