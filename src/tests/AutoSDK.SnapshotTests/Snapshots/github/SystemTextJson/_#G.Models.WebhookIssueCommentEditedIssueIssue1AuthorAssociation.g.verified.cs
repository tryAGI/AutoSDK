//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1AuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Member => "MEMBER",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.None => "NONE",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Member,
                "NONE" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.None,
                "OWNER" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}