//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1AuthorAssociation
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
    public static class WebhookIssueCommentCreatedIssueVariant1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.NONE => "NONE",
                WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentCreatedIssueVariant1AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}