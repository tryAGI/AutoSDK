//HintName: G.Models.WebhookPullRequestLabeledPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestAssigneeType
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
    public static class WebhookPullRequestLabeledPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestLabeledPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestLabeledPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestLabeledPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestLabeledPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}