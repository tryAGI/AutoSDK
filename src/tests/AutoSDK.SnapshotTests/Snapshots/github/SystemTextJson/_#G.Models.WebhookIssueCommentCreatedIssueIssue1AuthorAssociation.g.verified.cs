//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1AuthorAssociation
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
    public static class WebhookIssueCommentCreatedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Member => "MEMBER",
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.None => "NONE",
                WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Member,
                "NONE" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.None,
                "OWNER" => WebhookIssueCommentCreatedIssueIssue1AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}