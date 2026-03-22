//HintName: G.Models.WebhookIssuesEditedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssueMilestoneCreatorType
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
    public static class WebhookIssuesEditedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesEditedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssuesEditedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesEditedIssueMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueMilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssuesEditedIssueMilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssuesEditedIssueMilestoneCreatorType.Organization,
                "User" => WebhookIssuesEditedIssueMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}