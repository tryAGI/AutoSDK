//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1AssigneeType2
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueVariant1AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1AssigneeType2 value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1AssigneeType2.Bot => "Bot",
                WebhookIssueCommentEditedIssueVariant1AssigneeType2.User => "User",
                WebhookIssueCommentEditedIssueVariant1AssigneeType2.Organization => "Organization",
                WebhookIssueCommentEditedIssueVariant1AssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueVariant1AssigneeType2.Bot,
                "User" => WebhookIssueCommentEditedIssueVariant1AssigneeType2.User,
                "Organization" => WebhookIssueCommentEditedIssueVariant1AssigneeType2.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueVariant1AssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}