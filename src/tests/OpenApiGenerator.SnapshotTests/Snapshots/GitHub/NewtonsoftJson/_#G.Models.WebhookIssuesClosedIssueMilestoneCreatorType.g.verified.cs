//HintName: G.Models.WebhookIssuesClosedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueMilestoneCreatorType
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
    public static class WebhookIssuesClosedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesClosedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesClosedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesClosedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesClosedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesClosedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}