//HintName: G.Models.WebhooksPullRequest5MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5MilestoneCreatorType
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
    public static class WebhooksPullRequest5MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5MilestoneCreatorType value)
        {
            return value switch
            {
                WebhooksPullRequest5MilestoneCreatorType.Bot => "Bot",
                WebhooksPullRequest5MilestoneCreatorType.User => "User",
                WebhooksPullRequest5MilestoneCreatorType.Organization => "Organization",
                WebhooksPullRequest5MilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5MilestoneCreatorType.Bot,
                "User" => WebhooksPullRequest5MilestoneCreatorType.User,
                "Organization" => WebhooksPullRequest5MilestoneCreatorType.Organization,
                "Mannequin" => WebhooksPullRequest5MilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}