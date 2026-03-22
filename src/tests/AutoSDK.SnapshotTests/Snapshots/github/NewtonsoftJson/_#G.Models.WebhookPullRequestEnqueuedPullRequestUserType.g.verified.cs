//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestEnqueuedPullRequestUserType
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
    public static class WebhookPullRequestEnqueuedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestEnqueuedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestEnqueuedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestEnqueuedPullRequestUserType.Organization,
                "User" => WebhookPullRequestEnqueuedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}