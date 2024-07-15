//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestAssigneesType
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
    public static class WebhookPullRequestUnlabeledPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestAssigneesType.User => "User",
                WebhookPullRequestUnlabeledPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}