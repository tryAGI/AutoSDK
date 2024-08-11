//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1AuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        OWNER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueVariant1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.NONE => "NONE",
                WebhookIssueCommentEditedIssueVariant1AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentEditedIssueVariant1AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}